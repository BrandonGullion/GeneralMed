   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeneralMed2._0GeneralMed2._0  A%clr-namespace:GeneralMed2._0.ControlsGeneralMed2._0.Controls  ,    &GeneralMed2._0.Pages.PatientSearchPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:GeneralMed2._0     :controls%clr-namespace:GeneralMed2._0.Controls     $	��500��  N� Title$  PatientSearchPage�� � 	Resources %   GeneralMed2._0.CentralViewModel   CentralViewModel��%   &	          .��� 
������� � DataContext# [   � RowDefinitions �� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto �.+�� $��0��.+���   RegularButton#��[ $��Select Patient��$��Right=�  ForegroundMainBrush#��[ $��10q�$��20(����� *SelectPatientCommand+���� *SelectedPatient+�� #��[ $��Insert Patient��#��[ $
��Left=�$��10q�$��20(����� *InsertPatientCommand+�� $��1q�$��1������  �� 
StartPoint$	 1,0&� �� EndPoint$	 0,1&�.���  � Color$ Transparent�� � Offset$	 0.0Q��   GrayUnderline# [ $
 0.25Q�� # [ $
 0.75Q�� $ Transparent��$	 1.0Q��� $��2��.+��  � ColumnDefinitions �� $	��150 ��� $	��160 ��� $	��100 ��� $	��100 � �� $��* ��� $
��Auto �.+���   BaseTextBlock#��[ $��	Last Name��$��14(�$��10 0 0 0q��� #��[ $��
First Name��$��1��$��14(�$��10 0 0 0q��� #��[ $��Date of Birth��$��2��$��14(��� #��[ $��Last Updated��$��3��$��14(�$��5 0 0 2q��� $��1q�$��1��$��4������ $	 1,0&�$	 0,1&�.��� $ Transparent��$	 0.0Q�� # [ $
 0.25Q�� # [ $
 0.75Q�� $ Transparent��$	 1.0Q��� -   	 ��Name$	 PatientList��$��0q�$	��Top=����� *FilteredList+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedValue �� *SelectedPatient+���� .R�4   .GeneralMed2._0.Controls.PatientListItemControl  � $��3��.+��� -    ��Name$ UpdatePatientButton��$��Update Patient��$
��Left=�#��[ $��20(�#��[ ���� * OpenUpdatePatientWindowCommand+�� -   $ DeletePatientButton��$��Delete Patient��$��20(�#��[ $��Right=�#��[ ���� *DeletePatientWindowCommand+