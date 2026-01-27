using System;

namespace Collections.collection_csharp_practice.gcr_codebase.annotations
{
    class LegacyAPI
    {
        [Obsolete("Use NewFeature instead")]
        public void OldFeature()
        {
            Console.WriteLine("Old feature");
        }

        public void NewFeature()
        {
            Console.WriteLine("New feature");
        }
    }

    class ObseleteAttributeProgram
    {
        static void Main()
        {
            LegacyAPI api = new LegacyAPI();
            api.OldFeature();  
            api.NewFeature();
        }
    }
}
