   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:GeneralMed2._0.WindowsGeneralMed2._0.Windows  /clr-namespace:GeneralMed2._0GeneralMed2._0  *    $GeneralMed2._0.Windows.AddDrugWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6local$clr-namespace:GeneralMed2._0.Windows     /local2clr-namespace:GeneralMed2._0     -     �Name$  _AddDrugWindow�� � WindowStyle$
 None=� � AllowsTransparency . 
������  � Title$ AddDrugWindow��$	��400��$	��800�� � 	Resources +   %GeneralMed2._0.AddDrugWindowViewModel   vm��%   &	          .��� .+���  �� Padding$ 15q� �� CornerRadius$ 20��
�������$	��1.5q�  ForegroundLightBrush#��[ ._��  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto � � ColumnDefinitions �� $��* ��� $
��Auto ��� $��* �.+��� -   $��30��$��	0 -10 0 0q�
������ $��3��._��  �� $��* ��� $
��Auto �.+��� $��Drug Settings��  ForegroundMainBrush#��[ $��18(��� -   $��2��$��[ X ]��$��Calibri)�#��[   IconButtonForegroundMain#��[ $��Right=�$��20(�$��0,0,5,0q��� $��1��.+��� $��	Add Drug:��  BaseTextBlock#��[ $��20(��� $��
Drug Name:��#��[ $��18(��� -   	 ��Name$	 FirstNameTextBox��  UnderlineTextBox#��[ $��18(�#��[ $��0 0 0 5q����� *
DrugName+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=��� $��General Purpose:��#��[ $��20(���  �� DisplayMemberPath$ 
GeneralUse��$��0 0 0 1q� �� 
IsEditable . #��[ $��16(����� *GeneralUseList+ �� SelectedValue �� *LeftGeneralUse+$ TwoWay=�$
 PropertyChanged=���   RegularButton#��[ $
��Save��$��Center=�#��[ $��20(����� *SaveNewDrugCommand+�� $��2q�$��2��$��1��$��4��$��5q�����  �� 
StartPoint$	 0,0&� �� EndPoint$	 1,1&�.���  � Color$ Transparent�� � Offset$	 0.0Q��   GrayUnderline# [ $
 0.25Q�� # [ $
 0.75Q�� $ Transparent��$	 1.0Q�� $��1��$��2��.+��� $ 5 0 0 0q�._��� .+��� $��Update Drug:��$��20(�#��[ �� #��[ #��[ $��14(�$+��%Select desired drug to edit or delete���� $��0 0 0 1q� . $ DrugName��#��[ $��16(����� *DrugModelList+ �� SelectedItem �� *SelectedUpdate+$ TwoWay=�$
 PropertyChanged=��� $��
Drug Name:��#��[ $��18(��� #��[ $��18(�#��[ $��0 0 0 5q����� *SelectedUpdate.DrugName+$
 PropertyChanged=�$ TwoWay=��� $��General Purpose:��#��[ $��18(��� $ 
GeneralUse�� . $��0 0 0 1q�#��[ $��16(����� *GeneralUseList+ �� *SelectedItem.General+ �� *RightGeneralUse+$ TwoWay=�$
 PropertyChanged=�� 
������  �� $
��257* ��� $
��115* �.+��� $��Delete��#��[ $��16(�$
��Left=�$��5,5,0,5q����� *DeleteSelectedDrugCommand+�� $��Update��#��[ $��16(�$��Right=�$��1��$��0,5,5,5q����� *UpdateSelectedDrugCommand+