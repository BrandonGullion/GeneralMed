   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeneralMed2._0GeneralMed2._0  A%clr-namespace:GeneralMed2._0.ControlsGeneralMed2._0.Controls  '    !GeneralMed2._0.Pages.CalendarPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:GeneralMed2._0     9control%clr-namespace:GeneralMed2._0.Controls     $	��200��$	��200��  N� Title$  Calendar�� � 	Resources )   #GeneralMed2._0.AccuWeatherViewModel   AccuWeatherViewModel��%   &	          .��� 
������� � DataContext# [   � RowDefinitions �� $��* ��� $
��Auto �.+��� .+�(� $��0��.����  �� Padding$ 5q�._�&   System.Windows.Controls.Calendar    MainCalendar#���    MainCalendarItemStyle   CalendarItemStyle# �    MainCalendarButtonStyle   CalendarDayButtonStyle# �  $��0q���  # WeatherLightBlueBackgroundBrush#��[ # [   �� CornerRadius$ 10��$ 10q�._��  � ColumnDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��.+��� -   	 ��Name$	 	IconImage��$��/Icons/ErrorCloud.png��$��80��$
��Left=�$��Center=��� -   
 ��Name$
 WeatherTextTexBlock��$��Current Conditions��  BaseTextBlock#��[   FontSizeRegular#��[ � $��1�� �� $��* ��� $��* �.+���  �� Orientation$ 
Horizontal=�$��Right=�.+��� -   $
 CurrentTempTextBlock��$��--��#��[ $��40(��� $	��°C��#��[ $	��Top=�$��0 5 0 0 q�$��30(��� -   $
 CityTextBlock��$��1��#��[ $
��City��$��30(�$��Right=�$��Center=���   IconButtonWhite#��[ 
�������  FontAwesome#��[ $��30(�$	����$��2��$��Bottom=�$��5 5 5 7q����� *OpenCitySearchCommand+