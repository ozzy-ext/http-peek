using MyLab.Wpf;

namespace HttpPeek.Vms
{
    class DesignMainVm : MainVm
    {
        public DesignMainVm()
        {
            CurrentProject = new DesignProjectVm();
        }
    }

    class DesignProjectVm : ProjectVm
    {
        public DesignProjectVm() 
            : base(new DesignTimeViewModelFactory())
        {
            Title = "Test project";

            RootCollection = new DesignRootRequestCollectionVm();

        }
    }

    class DesignRootRequestCollectionVm : RequestCollectionVm
    {
        public DesignRootRequestCollectionVm()
        {
            Collections.Add(new RequestCollectionVm
            {
                Title = "Request sending",
                Requests =
                {
                    new RequestVm
                    {
                        Title = "yandex",
                        Method = "head",
                        Path = "http://yandex.ru"
                    },

                    new RequestVm
                    {
                        Title = "yandex-2",
                        Method = "delete",
                        Path = "http://yandex.ru/something"
                    }
                }
            });

            Collections.Add(new RequestCollectionVm
            {
                Title = "Users",
                Requests =
                {
                    new RequestVm
                    {
                        Title = "yandex-3",
                        Method = "options",
                        Path = "http://yandex.ru"
                    }
                }
            });

            Collections.Add(new RequestCollectionVm
            {
                Title = "Management"
            });

            Requests.Add(new RequestVm
            {
                Title = "yandex-4",
                Method = "Get",
                Path = "http://yandex.ru"
            });

            Requests.Add(new RequestVm
            {
                Title = "yandex-5",
                Method = "post",
                Path = "http://yandex.ru/something"
            });
            Requests.Add(new RequestVm
            {
                Title = "google-1",
                Method = "put",
                Path = "http://google.com"
            });

            Requests.Add(new RequestVm
            {
                Title = "Google-2",
                Method = "patch",
                Path = "http://google.com/something"
            });
        }
    }
}
