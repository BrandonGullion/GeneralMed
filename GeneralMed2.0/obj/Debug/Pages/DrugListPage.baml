   M S B A M L   `   `   `  ����H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:GeneralMed2._0.PagesGeneralMed2._0.Pages  5      /clr-namespace:GeneralMed2._0GeneralMed2._0  5      A%clr-namespace:GeneralMed2._0.ControlsGeneralMed2._0.Controls  5      '    !GeneralMed2._0.Pages.DrugListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:GeneralMed2._0.Pages     5      +vmclr-namespace:GeneralMed2._0     5      9control%clr-namespace:GeneralMed2._0.Controls     5        N� Title$  DrugListPage��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $	����6      FontAwesome#��[  5        IconButtonForegroundMain#��[ 5      $��Center=�5      $
��Left=�5      $��24(�5      ��5      �� *BackButtonCommand+�� 5   
   $	����6   #��[  5      #��[ 5       $��Center=�5!      $��Center=�5"      $��24(�5#      ��5$      �� *HomeCommand+� 5&   
   $��1��6    � ColumnDefinitions 5'      �� 5(      $��* �6#   �� 5)      $
��Auto �6#   �� 5*      $
��Auto �6#   .+�5-      �� $��10q�6    �� Text$# Begin Typing To Select A Drug��5.      $��0��5/      $��0 0 0 1q�50       �� DisplayMemberPath$ DrugName��53       �� 
IsEditable .  �� SelectedItem 51      �� *SelectedDrugModel+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���52      �� *
DrugList+55      �� 57      $��1��6     UnderlineTextBox#��[ 58      
	 � Tag$	 Stength��5:      
 �� TextAlignment$
 Center=�5;      $	��150��5<      ��59      �� *SelectedStrength+$ TwoWay=�$ PropertyChanged=�5<      �� 5>      #��[ 6   $	����5?        ForegroundMainBrush#��[ 5A      #��[  5B      $��24(�5C      $��2��5D      ��5@      �� *AddDrugCommand+5D      5E      � 5G   
   $��2��6    5H      �� 5I      $	��135 �6#   �� 5J      $��80 �6#   �� 5K      $	��150 �6#   �� 5L      $	��110 �6#   �� 5M      $��80 �6#   .+�5P      �� $��	Drug Name��6   $��8 0 0 2q�5Q        BaseTextBlock#��[ 5R      $��0��5S      �� 5U      $��Strength��6   #��[ 5V      $��1��5W      �� 5Y      $��General Purpose��6   #��[ 5Z      $��2��5[      �� 5]      $��
Date Added��6   #��[ 5^      $��3��5_      �� 5a      $��Last Updated��6   #��[ 5b      $��4��5c      5d      �� 5f   
   $��3��6   $��0,0,0,5q�5g      $��0q�5h       5i      �� *SelectedPatientDrugModel+$ TwoWay=�$ PropertyChanged=���5j      �� *FilteredPatientDrugModelList+$ PropertyChanged=���5k      �� 5l      .R�5m      1   +GeneralMed2._0.Controls.DrugListItemControl  5n      5q      �� 5s   
   $��4��6   $��18(�5t      $��Delete Selected Drug��5u        RegularButton#��[ 5w      $��Right=�5x      ��5v      �� *DeleteSelectedDrugCommand+5x      �� 5{   
   $��4��6   $��18(�5}      $��Export��5~      #��[ 5      $
��Left=�5�      ��5|      �� *ExportCommand+5�      5�      5�      