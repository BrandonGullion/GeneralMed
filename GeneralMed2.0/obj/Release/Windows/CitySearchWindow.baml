   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeneralMed2._0GeneralMed2._0  A%clr-namespace:GeneralMed2._0.ControlsGeneralMed2._0.Controls  %    GeneralMed2._0.CitySearchWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:GeneralMed2._0     :controls%clr-namespace:GeneralMed2._0.Controls     -     �Name$  AccuWeatherSearchWindow�� � Title$ CitySearchWindow��$	��600��$	��400�� � AllowsTransparency .  � WindowStyle$
 None=�
������  � WindowStartupLocation$ CenterScreen=� � 
ResizeMode$ 	CanResize=� � 	Resources )   #GeneralMed2._0.AccuWeatherViewModel   AccuWeatherViewModel��%   &	          .����  �� Padding$ 15q� �� CornerRadius$ 20��
�������$	��1.5q�  ForegroundLightBrush#��[ ._�� 	 � DataContext#	 [  
 � RowDefinitions
 �� $��* ��� $
��Auto �.+��� $��0��.+��� -   $��30��$��	0 -10 0 0q�
������ ._��  � ColumnDefinitions �� $��* ��� $
��Auto �
 �� $��* ��� $
��Auto �.+��� $ ��AccuWeather City Selection��  ForegroundMainBrush#��[ $��18(��� -   $��1��$��[ X ]��$��30��$��Center=�$��Calibri)�#��[   IconButtonForegroundMain#��[ $��Right=�$��20(��� $��Adjust Weather Location:��$��16(�$��0 5 0 0q���  �� Orientation$ 
Horizontal=�.+���   DrugSearchTextbox#��[ 
 � Tag$ Enter City Name��$��20(�#��[   LatoRegular#��[ $	��330������ *Query+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=��� #	 [  $��1��  
IconButton#��[ $	����#��[   FontSizeMediumLarge#��[   FontAwesome#��[ $��Right=�$��Center=� 	 IconBackgroundGrayBrush#��[	 ���� *CitySearchCommand+���� *Query+� .+��� .���� -    ��Name$ CityListView��#	 [  $��0q����� *Cities+ �� SelectedValue �� *SelectedCityModel+���� .R�<   6GeneralMed2._0.Controls.AccuWeatherCityListItemControl  �� -    ��Name$ CloseWindowButton��$��30(� 
 RegularButton#��[
 $
��Save��$��1��$��Right=�#��[ 