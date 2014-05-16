using System.ServiceModel.Channels;

namespace WcfRawDemo
{
    public class RawContentTypeMapper : WebContentTypeMapper
    {
        public override WebContentFormat GetMessageFormatForContentType(string contentType)
        {
            //Make if-else statements here if you want to respond differently to different contentTypes. This one will always return Raw regardless of what you attack it with.
            return WebContentFormat.Raw;
        }
    }
}