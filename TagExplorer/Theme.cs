using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagExplorer
{
    public class Theme
    {
        private string name;
        public string Name
        {
            get { return name;  }
            set { name = value; }
        }

        #region Font
        private string font;
        public string Font
        {
            get { return font; }
            set { font = value; }
        }
        private float fontSize;
        public float FontSize
        {
            get { return fontSize; }
            set { fontSize = value; }
        }
        #endregion

        #region Defeault colors
        private List<Tuple<string, string>> defaultColors;
        public void SetDefaultColorByName(string name, string newValue)
        {
            if(FindColorByName(name) == newValue) return;
            if(FindColorByName(name) == null) throw new Exception("Color with that name dont found."); //TODO: write more right throwing;
            DeleteColorByName(name);
            // TODO: Check new value first add. 
            defaultColors.Add(new Tuple<string, string>(name, newValue));
        }
        private void DeleteColorByName(string name)
        {
            for (int i = 0; i < defaultColors.Count; i++)
            {
                if (defaultColors[i].Item1 == name)
                {
                    defaultColors.RemoveAt(i);
                }
            }
        }
        private string FindColorByName(string name) 
        { 
            foreach (var color in defaultColors)
            {
                if (color.Item1 == name)
                    return color.Item2;
            }
            return null;
        }
        public System.Drawing.Color GetColorByName(string name) 
        {
            string color = FindColorByName(name);
            if (color == null) throw new Exception($"Haven't color with name {name}");
            
            if (color.StartsWith("#"))
            {
                return System.Drawing.ColorTranslator.FromHtml(color);
            }

            if (color.StartsWith("("))
            {
                string[] colorsParts = color.Split(',');
                char[] trimChars = {' ', '(', ')', ','};
                int A = 255;
                if (colorsParts.Length > 3) 
                    A = int.Parse(colorsParts[3].Trim(trimChars));
                int R = int.Parse(colorsParts[0].Trim(trimChars));
                int G = int.Parse(colorsParts[1].Trim(trimChars));
                int B = int.Parse(colorsParts[2].Trim(trimChars));    
                return System.Drawing.Color.FromArgb(A, R, G, B); 
            }

            throw new Exception($"Color with name \"{name}\" cannot be drawn.");
            // TODO: check is null;
        }
        #endregion

        #region Special detail
        private List<Tuple<string, string, string>> specialDetails; // <component name>, <parameter name>, <value>
        public void AddSpecialDetail(string component, string parameter, string value)
        {
            specialDetails.Add(new Tuple<string, string, string>(component, parameter, value));
        }
        #endregion

        public Theme() 
        {
            #region Set default values

            font = "Microsoft Sans Serif";
            fontSize = 12;

            defaultColors = new List<Tuple<string, string>>();
            defaultColors.Add(Tuple.Create("fontColorMain", "#000000"));
            defaultColors.Add(Tuple.Create("fontColorShadow", "#000000"));
            defaultColors.Add(Tuple.Create("space", "#FFFFFFFF"));
            defaultColors.Add(Tuple.Create("menuMain", "(153, 180, 209)"));
            defaultColors.Add(Tuple.Create("menuSecond", "(115, 151, 191)"));
            defaultColors.Add(Tuple.Create("tools", "(240, 240, 240)"));
            defaultColors.Add(Tuple.Create("toolsSecond", "(200, 200, 200)"));
            defaultColors.Add(Tuple.Create("border", "#AAAAAA"));
            defaultColors.Add(Tuple.Create("selectedButton", "#00FF00"));
            defaultColors.Add(Tuple.Create("deselectedButton", "#FFFFFF"));

            specialDetails = new List<Tuple<string, string, string>>();

            #endregion
        }

    }
}
