using HttpPeek.Vms;
using MyLab.Wpf;

namespace HttpPeek.Design
{
    public class DesignRequestFolderNodeVm : RootRequestFolderNodeVm
    {
        public DesignRequestFolderNodeVm()
        {
            var f = new DesignTimeViewModelFactory();

            var selected = f.Create(() =>
                new RequestNodeVm(f)
                {

                    Title = "yandex-2",
                    Method = "delete",
                    Path = "http://yandex.ru/something",
                    Selected = true
                });

            SelectedNode = selected;

            Children.Add(
                f.Create(() => 
                
                new RequestFolderNodeVm
            {
                Title = "Request sending",
                Expanded = true,
                Children =
                {
                    f.Create(()=>new RequestNodeVm(f)
                    { 
                            Title = "yandex",
                            Method = "head",
                            Path = "http://yandex.ru"
                    }),

                    selected
                }
            })) ;

            Children.Add(
                f.Create(()=>
                new RequestFolderNodeVm
            {
                Title = "Users",
                Expanded = true,
                Children =
                {
                    f.Create(()=> new RequestNodeVm(f)
                    {
                            Title = "yandex-3",
                            Method = "options",
                            Path = "http://yandex.ru"
                      
                    })
                }
            }));

            Children.Add(f.Create( () => new RequestFolderNodeVm
            {
                Title = "Management"
            }));

            Children.Add(f.Create(() => new RequestNodeVm(f)
            {
                
                    Title = "yandex-4",
                    Method = "Get",
                    Path = "http://yandex.ru"
                
            }));

            Children.Add(f.Create(() => new RequestNodeVm(f)
            {
                
                    Title = "yandex-5",
                    Method = "post",
                    Path = "http://yandex.ru/something"
                
            }));
            Children.Add(f.Create(() => new RequestNodeVm(f)
            {
                
                    Title = "google-1",
                    Method = "put",
                    Path = "http://google.com"
               
            }));

            Children.Add(f.Create(()=> new RequestNodeVm(f)
            {
                
                    Title = "Google-2",
                    Method = "patch",
                    Path = "http://google.com/something"
                
            }));
        }
    }
}