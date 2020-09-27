using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BaseBusiness
{
    public class PropertyMap
    {
        public PropertyInfo SourceProperty { get; set; }
        public PropertyInfo TargetProperty { get; set; }
    }

    public abstract class ObjectCopyBase : IDisposable
    {
        public abstract void MapTypes<T, TU>();
        public abstract void Copy<T, TU>(T source, TU target);

        protected virtual IList<PropertyMap> GetMatchingProperties<T, TU>()
        {
            var sourceProperties = typeof(T).GetProperties();
            var targetProperties = typeof(TU).GetProperties();

            var properties = (from s in sourceProperties
                              from t in targetProperties
                              where s.Name == t.Name &&
                                    s.CanRead &&
                                    t.CanWrite &&
                                    s.PropertyType == t.PropertyType
                              select new PropertyMap
                              {
                                  SourceProperty = s,
                                  TargetProperty = t
                              }).ToList();
            return properties;
        }

        protected virtual string GetMapKey<T, TU>()
        {
            var className = "Copy_";
            className += typeof(T).FullName.Replace(".", "_");
            className += "_";
            className += typeof(TU).FullName.Replace(".", "_");

            return className;
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }

    public class CopyHelper : ObjectCopyBase
    {
        private readonly Dictionary<string, PropertyMap[]> _maps =
            new Dictionary<string, PropertyMap[]>();

        public override void MapTypes<T, TU>()
        {
            var key = GetMapKey<T, TU>();
            if (_maps.ContainsKey(key))
                return;

            var props = GetMatchingProperties<T, TU>();
            _maps.Add(key, props.ToArray());
        }

        public override void Copy<T, TU>(T source, TU target)
        {
            var key = GetMapKey<T, TU>();
            if (!_maps.ContainsKey(key))
                MapTypes<T, TU>();

            var propMap = _maps[key];

            foreach (var prop in propMap)
            {
                try
                {
                    var sourceValue = prop.SourceProperty.GetValue(source, null);
                    prop.TargetProperty.SetValue(target, sourceValue, null);
                }
                catch { }
            }
        }
    }
}
