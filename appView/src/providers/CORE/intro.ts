export var introAppData = {
	introList: [
        {
            page: "page-member",
            intro: {
                steps: [
                  {
                    intro: "Hello world!"
                  },
                  {
                    element: '#step1',
                    intro: "This is a tooltip.",
                    position: 'bottom'
                    
                  },
                  {
                    
                    intro: 'More features, more <span style="color: red;">f</span><span style="color: green;">u</span><span style="color: blue;">n</span>.',
                
                  }
                ]
              }
        }
        
    ],
	getIntroByPage:function(page){
        let result = introAppData.introList.find(d=>d.page==page);
		return result;
	}
}