   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:GeneralMed2._0.WindowsGeneralMed2._0.Windows  0    *GeneralMed2._0.Windows.DeletePatientWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:GeneralMed2._0.Windows       � AllowsTransparency  . 
������  � WindowStyle$
 None=� � Title$ DeletePatientWindow��$	��200��$	��400��.��� .+���  �� Padding$ 15q� �� CornerRadius$ 20��
�������$	��1.5q�   ForegroundLightBrush#��[  ._��  � RowDefinitions �� $
��Auto ��� $��* �.+��� -    ��Name$ WindowHeader��$��0��$��	0 -15 0 0q�._�� .+��� $��Delete Selected Patient��  BaseTextBlock#��[ $��20(��� -   $��[ X ]��  RegularButton#��[ $��Right=�$��20(�$��0��� $��1�� �� $
��Auto ��� $��2 ��� $��* �.+��� #��[ $��0��$]��WDeleting patient will remove all related drug lists, are you sure you want to continue?��$	��Top=�$
��Wrap=�$��16(��� $��2q�$��1������  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.��� 	 � Color$	 Transparent��
 � Offset$	
 0.0Q��   GrayUnderline#	 [ $

 0.25Q�� #	 [ $

 0.75Q�� $	 Transparent��$	
 1.0Q��� -    ��Name$ ConfirmButton��$��Center=�$��2��$��Center=�$	��Yes��$��	0 0 150 0q�$��25(�#��[ �� -   $ CancelButton��$��Center=�$��2��$��Center=�$��No��$��	150 0 0 0q�$��25(�#��[ 