﻿        private SolidColorBrush GetStandardTextColorBrush()
        {
            var result = Application.Current.Resources["SystemControlForegroundBaseHighBrush"] as SolidColorBrush;

            //{[{
            if (!Services.ThemeSelectorService.IsLightThemeEnabled)
            {
                result = Application.Current.Resources["SystemControlForegroundAltHighBrush"] as SolidColorBrush;
            }
            //}]}
            return result;
        }

        public ShellNavigationItem(string label, Symbol symbol, string viewModelName)
        {
            this.Label = label;
            this.Symbol = symbol;
            this.ViewModelName = viewModelName;

            //^^
            //{[{
            Services.ThemeSelectorService.OnThemeChanged += (s, e) => { if (!IsSelected) SelectedForeground = GetStandardTextColorBrush(); };
            //}]}
        }
