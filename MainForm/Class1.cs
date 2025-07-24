using System.Collections.Generic;

namespace MainForm
{
    public class RootObject
    {
        public Dictionary<string, ImageItem> images { get; set; }
        public Dictionary<string, ButtonItem> buttons { get; set; }
        public Dictionary<string, LabelItem> labels { get; set; }
        public Dictionary<string, OtherItem> other { get; set; }
    }

    public class ImageItem
    {
        public string image { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string alignment { get; set; }
        public bool? stretch { get; set; }
        public bool? keepAspect { get; set; }
    }

    public class ButtonItem
    {
        public string text { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public ActionItem action { get; set; }
        public string texture { get; set; }
    }

    public class ActionItem
    {
        public string type { get; set; }
        public string gui { get; set; }
    }

    public class LabelItem
    {
        public string text { get; set; }
        public string hoverText { get; set; }
        public int posX { get; set; }
        public int posY { get; set; }
        public int color { get; set; }
        public string alignment { get; set; }
        public ActionItem action { get; set; }
    }

    public class OtherItem
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public int color { get; set; }
        public string alignment { get; set; }
        public string texts { get; set; }
    }
}