   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeneralMed2._0GeneralMed2._0  0    *GeneralMed2._0.Windows.InsertPatientWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:GeneralMed2._0       � WindowStyle$
  None=� � AllowsTransparency . 
������  � WindowStartupLocation$ CenterOwner=� � Title$ InsertPatientWindow��$	��500��$	��400�� � 	Resources %   GeneralMed2._0.CentralViewModel   CentralViewModel��%   &	          .���  � DataContext# [  .+���  �� Padding$ 15q� �� CornerRadius$ 20��
�������$	��1.5q�  ForegroundLightBrush#��[ ._��  � RowDefinitions �� $
��Auto ��� $��* ��� $
��Auto �.+��� $��0��.+��� -   $��30��$��	0 -10 0 0q�
������ ._�� 	 � ColumnDefinitions	 �� $��* ��� $
��Auto �.+��� $��Insert Patient��  ForegroundMainBrush#��[ $��18(��� -   $��1��$��[ X ]��$��Calibri)�#��[   IconButtonForegroundMain#��[ $��Right=�$��20(�$��0,0,5,0q��� $��1��.+��� $��First Name:��  BaseTextBlock#��[ $��20(��� -   
 ��Name$
 FirstNameTextBox��  UnderlineTextBox#��[ $��20(�#��[ $��0 0 0 5q��� $��
Last Name:��#��[ $��20(��� -   $
 LastNameTextBox��#��[ $��20(�#��[ $��0 0 0 5q��� $!��Date Of Birth (DD/MM/YYYY):��#��[ $��20(��� -   $
 
DOBTextbox��$��24(�#��[ #��[ $��0 0 0 5q��� $��Room/Address��#��[ $��20(��� -   $
 AddressTextbox��$��24(�#��[ #��[ $��0 0 0 5q��� -    ��Name$ 
SaveButton��$��2��$
��Save��$��Bottom=�$��Right=�$��24(�  RegularButton#��[ 