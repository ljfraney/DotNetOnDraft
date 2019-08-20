[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
[System.Xml.Serialization.XmlRoot(Namespace = "", IsNullable = false)]
public partial class rss
{
    public rssChannel channel { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public decimal version { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannel
{
    public byte ttl { get; set; }

    public string title { get; set; }

    public string link { get; set; }

    public string language { get; set; }

    public string description { get; set; }

    public string copyright { get; set; }

    public string managingEditor { get; set; }

    public string webMaster { get; set; }

    public string rating { get; set; }

    public string pubDate { get; set; }

    public string lastBuildDate { get; set; }

    public rssChannelCloud cloud { get; set; }
    
    [System.Xml.Serialization.XmlElement("link", Namespace = "http://www.w3.org/2005/Atom")]
    public link link1 { get; set; }

    public rssChannelImage image { get; set; }

    [System.Xml.Serialization.XmlElement("category")]
    public string[] category { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string subtitle { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string @explicit { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string author { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string summary { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public owner owner { get; set; }

    [System.Xml.Serialization.XmlElement("image", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public image image1 { get; set; }

    [System.Xml.Serialization.XmlElement("category", Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public category[] category1 { get; set; }

    [System.Xml.Serialization.XmlElement("item")]
    public rssChannelItem[] item { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannelCloud
{
    [System.Xml.Serialization.XmlAttribute()]
    public string domain { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public byte port { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string path { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string registerProcedure { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string protocol { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.w3.org/2005/Atom")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://www.w3.org/2005/Atom", IsNullable = false)]
public partial class link
{
    [System.Xml.Serialization.XmlAttribute()]
    public string href { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string rel { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string type { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannelImage
{
    public string url { get; set; }

    public string title { get; set; }

    public string link { get; set; }

    public byte width { get; set; }
    
    public ushort height { get; set; }

    public string description { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
public partial class owner
{
    public string name { get; set; }

    public string email { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
public partial class image
{
    [System.Xml.Serialization.XmlAttribute()]
    public string href { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
[System.Xml.Serialization.XmlRoot(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", IsNullable = false)]
public partial class category
{
    [System.Xml.Serialization.XmlElement("category")]
    public categoryCategory category1 { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string text { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
public partial class categoryCategory
{
    [System.Xml.Serialization.XmlAttribute()]
    public string text { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannelItem
{
    public string title { get; set; }

    public string link { get; set; }

    public string pubDate { get; set; }

    public string description { get; set; }

    public rssChannelItemSource source { get; set; }

    public rssChannelItemGuid guid { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string author { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string subtitle { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public string summary { get; set; }

    public rssChannelItemEnclosure enclosure { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd", DataType = "time")]
    public System.DateTime duration { get; set; }

    [System.Xml.Serialization.XmlElement(Namespace = "http://www.itunes.com/dtds/podcast-1.0.dtd")]
    public uint keywords { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannelItemSource
{
    [System.Xml.Serialization.XmlAttribute()]
    public string url { get; set; }

    [System.Xml.Serialization.XmlText()]
    public string Value { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannelItemGuid
{
    [System.Xml.Serialization.XmlAttribute()]
    public bool isPermaLink { get; set; }

    [System.Xml.Serialization.XmlText()]
    public string Value { get; set; }
}

[System.Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true)]
public partial class rssChannelItemEnclosure
{
    [System.Xml.Serialization.XmlAttribute()]
    public string url { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public uint length { get; set; }

    [System.Xml.Serialization.XmlAttribute()]
    public string type { get; set; }
}