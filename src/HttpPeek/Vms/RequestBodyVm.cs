using System.Collections.ObjectModel;
using MyLab.Wpf;

namespace HttpPeek.Vms
{
    public class RequestBodyVm : ViewModel
    {
        protected RequestBodyVm()
        {
            
        }
    }

    public class RequestBodyCollection : Collection<RequestBodyVm>
    {
        public RequestBodyCollection(IVmFactory f)
        {
            Add(f.Create<MultipartFormRequestBodyVm>());
            Add(f.Create<FormUrlRequestBodyVm>());
            Add(f.Create<MultipartFormRequestBodyVm>());
            Add(f.Create<JsonRequestBodyVm>());
            Add(f.Create<XmlRequestBodyVm>());
            Add(f.Create<YamlRequestBodyVm>());
            Add(f.Create<TextRequestBodyVm>());
            Add(f.Create<BinaryRequestBody>());
            Add(f.Create<NoBodyRequestBodyVm>());
        }
    }

    public class NoBodyRequestBodyVm : RequestBodyVm
    {
        public NoBodyRequestBodyVm()
        {
            Title = "No Body";
        }
    }

    public class MultipartFormRequestBodyVm : RequestBodyVm
    {
        public MultipartFormRequestBodyVm()
        {
            Title = "Multipart Form";
        }
    }

    public class FormUrlRequestBodyVm : RequestBodyVm
    {
        public FormUrlRequestBodyVm()
        {
            Title = "Form URL Encoded";
        }
    }

    public class TextRequestBodyVm : RequestBodyVm
    {
        public TextRequestBodyVm()
        {
            Title = "TEXT";
        }
    }

    public class JsonRequestBodyVm : RequestBodyVm
    {
        public JsonRequestBodyVm()
        {
            Title = "JSON";
        }
    }

    public class YamlRequestBodyVm : RequestBodyVm
    {
        public YamlRequestBodyVm()
        {
            Title = "YAML";
        }
    }

    public class XmlRequestBodyVm : RequestBodyVm
    {
        public XmlRequestBodyVm()
        {
            Title = "XML";
        }
    }

    public class BinaryRequestBody : RequestBodyVm
    {
        public BinaryRequestBody()
        {
            Title = "Binary file";
        }
    }
}