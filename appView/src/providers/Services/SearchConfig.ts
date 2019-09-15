export var SearchConfig = {
    defaultSearchFields: { cache: false, filelds: ['Code', 'Name', '_uid']},
    
    // CRM_CONTACT_KhachHang: { cache: true, filelds: ['Code', 'Name', 'MaSoThue', 'SoDienThoai1', 'SoDienThoai2', 'Email', '_uid']},
    // VANTAI_WO_LenhLamViec: { cache: false, filelds: ['Code', 'Name', '_uid']},
    // VANTAI_WO_NhatKyLamViec: { cache: false, filelds: ['Code', 'Name', '_uid']},

    getSearchFields: function (name) {
        let result = {
            name:name,
            value:this.defaultSearchFields
        };

        if (this[name]) {
            result.value = this[name];
            
        }
        
        return result;
    }
}