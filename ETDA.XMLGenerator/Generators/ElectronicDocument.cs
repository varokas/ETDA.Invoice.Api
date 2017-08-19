using iTextSharp.text.xml.xmp;

namespace ETDA.Invoice.Api.Generator
{
#pragma warning disable CS0612 // Type or member is obsolete
    internal class ElectronicDocument : XmpSchema
#pragma warning restore CS0612 // Type or member is obsolete
    {
        private static string XMLNS = "xmlns:ed=\"http://certificate.teda.th/schema/document/electronic_document#\"";
        private static string DocumentFileName = "ed:DocumentFileName";
        private static string DocumentVersion = "ed:DocumentVersion";
        private static string DocumentReferenceID = "ed:DocumentReferenceID";
        private static string DocumentOID = "ed:DocumentOID";

        public ElectronicDocument(string xmlns) : base(ElectronicDocument.XMLNS)
        {
            ;
        }

        public static ElectronicDocument generateED(string documentFilename, string documentVersion, string documentReferenceID,
        string documentOID)
        {
            ElectronicDocument ed = new ElectronicDocument("ed");
            ed.AddProperty(DocumentFileName, documentFilename);
            ed.AddProperty(DocumentVersion, documentVersion);
            ed.AddProperty(DocumentReferenceID, documentReferenceID);
            ed.AddProperty(DocumentOID, documentOID);
            return ed;
        }
    }
}