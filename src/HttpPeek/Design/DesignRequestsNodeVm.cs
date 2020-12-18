using HttpPeek.Vms;

namespace HttpPeek.Design
{
    public class DesignRequestsNodeVm : RootRequestsNodeVm
    {
        public DesignRequestsNodeVm()
        {
            var selected = new RequestNodeVm
            {

                Title = "yandex-2",
                Method = "delete",
                Path = "http://yandex.ru/something",
                Selected = true
            };

            SelectedNode = selected;

            Children.Add(new RequestsNodeVm
            {
                Title = "Request sending",
                Expanded = true,
                Children =
                {
                    new RequestNodeVm
                    { 
                            Title = "yandex",
                            Method = "head",
                            Path = "http://yandex.ru"
                    },

                    selected
                }
            }) ;

            Children.Add(new RequestsNodeVm
            {
                Title = "Users",
                Expanded = true,
                Children =
                {
                    new RequestNodeVm
                    {
                            Title = "yandex-3",
                            Method = "options",
                            Path = "http://yandex.ru"
                      
                    }
                }
            });

            Children.Add(new RequestsNodeVm
            {
                Title = "Management"
            });

            Children.Add(new RequestNodeVm
            {
                
                    Title = "yandex-4",
                    Method = "Get",
                    Path = "http://yandex.ru"
                
            });

            Children.Add(new RequestNodeVm
            {
                
                    Title = "yandex-5",
                    Method = "post",
                    Path = "http://yandex.ru/something"
                
            });
            Children.Add(new RequestNodeVm
            {
                
                    Title = "google-1",
                    Method = "put",
                    Path = "http://google.com"
               
            });

            Children.Add(new RequestNodeVm
            {
                
                    Title = "Google-2",
                    Method = "patch",
                    Path = "http://google.com/something"
                
            });
        }
    }
}