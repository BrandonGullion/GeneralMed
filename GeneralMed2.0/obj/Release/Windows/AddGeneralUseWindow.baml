   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:GeneralMed2._0.WindowsGeneralMed2._0.Windows  0    *GeneralMed2._0.Windows.AddGeneralUseWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:GeneralMed2._0.Windows       � AllowsTransparency  .  � WindowStyle$
 None=�
������  � Title$ AddGeneralUseWindow��$	��290��$	��400��.��� .+���  �� Padding$ 15q� �� CornerRadius$ 20��
�������$	��1.5q�   ForegroundLightBrush#��[  ._��  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* �.+��� $��0��.+��� -   $��30��$��	0 -10 0 0q�
������ ._��  � ColumnDefinitions �� $��* ��� $
��Auto �.+��� $#��Drug General Purpose Settings��  ForegroundMainBrush#��[ $��18(��� -   $��1��$��[ X ]��$��Calibri)�#��[   IconButtonForegroundMain#��[ $��Right=�$��20(�$��0,0,5,0q�� $��1�� �� $
��Auto ��� $
��Auto � �� $��* ��� $
��Auto �.+��� $!��Add Desired GeneralPurpose:��$��2��  BaseTextBlock#��[ $��16(��� -    ��Name$ FirstNameTextBox��  UnderlineTextBox#��[ $��1��
 � Tag$ Enter General Purpose��	 �� TextAlignment$	 Center=�$��16(�#��[ $��0 0 0 5q����� *GeneralUseString+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=��� $��2��$��1��$
��Save��$��5 10 5 5q�$��Bottom=�$��Right=�$��18(�  RegularButton#��[ ���� *SaveGeneralUseCommand+�� $��2��.+��� $1��+Select General Purpose To Update or Remove:��#��[ $��16(���  �� DisplayMemberPath$ 
GeneralUse�� �� SelectedItem �� *SelectedGeneralUse+$ TwoWay=�$
 PropertyChanged=����� *GeneralUseList+�� #��[ $��0 15 0 0q�#��[ $ New Purpose�� �� TextAlignment$ Center=����� *LocalGeneralUse+$ TwoWay=�$
 PropertyChanged=�� $��0 15 0 0q�.+��� $��Delete��#��[ $
��Left=����� *DeleteSelectedPurposeCommand+�� $��Update��#��[ $��Right=����� *UpdateSelectedPurposeCommand+