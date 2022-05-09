using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TagExplorer
{
    public static class DesignManager
    {
        public delegate void NoParameter();
        public static event NoParameter UpdateComponents;

        private static List<Tuple<string, string>> themesNames;
        public static List<string> ThemesNames
        {
            get 
            { 
                List<string> result = new List<string>();
                foreach (var theme in themesNames)
                    result.Add(theme.Item1); //add theme name
                return result; 
            }
        }

        private static string currentThemePath;
        private static Theme theme;
        public static Theme Theme
        {
            get { return theme; }
            set { }
        }

        public static void Inicialize()
        {
            theme = new Theme();
            themesNames = new List<Tuple<string, string>>();
            ReadCurrentSettings();
            ReadCurrentTheme();
            ReadThemesNames();
            //SetNewThemeByName("Default Light");
        }

        private static string ReadParameter(string line) 
        {
            int parameterPartBegin = line.IndexOf(":") + 1;

            // TODO: need it or not??
            //if (parameterPartBegin <= 0)
            //{
            //    throw new ArgumentException(paramName: line, message: "Havent parameter name.");
            //}

            string parameterValue = line.Substring(parameterPartBegin).Trim();
            
            if (parameterValue == "")
            {
                throw new ArgumentNullException(paramName: line, message: $"Haven't parameter in string \"{line}\"");
            }

            return parameterValue;
        }

        private static void ReadThemesNames()
        {
            var files = Directory.GetFiles(Paths.themesFolder, "*.*", SearchOption.TopDirectoryOnly);
            foreach (var file in files)
            {
                using (StreamReader theme = new StreamReader(file))
                {
                    string line;

                    while ((line = theme.ReadLine()) != null)
                    {
                        if (line.StartsWith("ThemeName"))
                        {
                            System.Diagnostics.Debug.WriteLine($"Finded theme {ReadParameter(line)}");
                            themesNames.Add(Tuple.Create(ReadParameter(line), file));
                        }
                    }
                }
            }
        }

        private static void ReadCurrentSettings() {
            using (StreamReader settings = new StreamReader(Paths.settingsFile))
            {
                string line;

                while ((line = settings.ReadLine()) != null)
                {
                    if (line.StartsWith("#"))
                        continue;
                    if (line.StartsWith("CurrentTheme"))
                    {
                        int parameterPartBegin = line.IndexOf(":")+1;
                        if (parameterPartBegin <= 0)
                        {
                            System.Diagnostics.Debug.WriteLine("Error: CurrentTheme hasn't parametr.");
                            continue; // TODO: think mb throw there?
                        }
                        currentThemePath = line.Substring(parameterPartBegin).Trim();
                        System.Diagnostics.Debug.WriteLine($"CurrentTheme patch is {currentThemePath}"); // TODO: think what do with that!
                        continue;
                    }
                }
                settings.Close();
            }
        }

        private static void ReadTheme(string themePatch) 
        {
            try
            {
                using (StreamReader themeFile = new StreamReader(themePatch))
                {
                    string line;

                    while ((line = themeFile.ReadLine()) != null)
                    {
                        // Dont read comment line.
                        if (line.StartsWith("#"))
                            continue;

                        // Read theme info
                        if (line.StartsWith("ThemeName"))
                        {
                            theme.Name = ReadParameter(line);
                            continue;
                        }

                        // Read base settings
                        if (line.StartsWith("def "))
                        {
                            string defLine = line.Substring(4);
                            string parameter = ReadParameter(defLine);

                            if (defLine.StartsWith("fontSize:"))
                            {
                                try
                                {
                                    theme.FontSize = float.Parse(parameter);
                                }
                                catch
                                {
                                    // TODO: error doing if not floatable data
                                }
                                continue;
                            }

                            if (defLine.StartsWith("fontColor:"))
                            {
                                try
                                {
                                    string colorName = defLine.Substring(0, defLine.IndexOf(":")).Trim();
                                    //System.Diagnostics.Debug.WriteLine($"{colorName}: {parameter}");
                                    theme.SetDefaultColorByName(colorName, parameter);
                                    System.Diagnostics.Debug.WriteLine($"Set default color {colorName}: {parameter}");
                                }
                                catch
                                {
                                    System.Diagnostics.Debug.WriteLine($"Error in set default color \n> {line}");
                                }
                            }

                            if (defLine.StartsWith("font:"))
                            {
                                theme.Font = parameter;
                                continue;
                            }

                            try
                            {
                                string colorName = defLine.Substring(0, defLine.IndexOf(":")).Trim();
                                //System.Diagnostics.Debug.WriteLine($"{colorName}: {parameter}");
                                theme.SetDefaultColorByName(colorName, parameter);
                                System.Diagnostics.Debug.WriteLine($"Set default color {colorName}: {parameter}");
                            }
                            catch
                            {
                                System.Diagnostics.Debug.WriteLine($"Error in set default color \n> {line}");
                            }
                        }

                        // Read specials settings
                    }
                    themeFile.Close();
                }
            }
            catch 
            {
                throw;
            }
        }

        private static void ReadCurrentTheme()
        {
            if (currentThemePath == null)
            {
                throw new ArgumentNullException(paramName: "currentThemePath", message: "Haven't currentThemePath value.");
            }
            ReadTheme(currentThemePath);
        }

        private static void WriteCurrentThemePath(string themePatch)
        {
            string[] settingsLines = File.ReadAllLines(Paths.settingsFile);
            for (int i = 0; i < settingsLines.Length; i++)
            {
                if (settingsLines[i].StartsWith("CurrentTheme"))
                {
                    settingsLines[i] = $"CurrentTheme: {themePatch}";
                    break;
                }
            }
            File.WriteAllLines(Paths.settingsFile, settingsLines);
        }

        public static void SetNewThemeByName(string themeName) 
        { 

            if (themeName == null) throw new ArgumentNullException(paramName: nameof(themeName), message: "Can't set new theme without new theme name");
            if (themeName == Theme.Name) return;

            System.Diagnostics.Debug.WriteLine($"Set Theme to {themeName}");
            foreach (var theme in themesNames)
            {
                if (themeName == theme.Item1)
                {
                    ReadTheme(theme.Item2);
                    // Write new current theme to settings file
                    WriteCurrentThemePath(theme.Item2);
                    UpdateComponents();
                    break;
                }
            }
        }
        
    }
}
