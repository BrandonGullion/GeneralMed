   M S B A M L   `   `   `  ����H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeneralMed2._0GeneralMed2._0  5      A%clr-namespace:GeneralMed2._0.ControlsGeneralMed2._0.Controls  5      ,    &GeneralMed2._0.Pages.PatientSearchPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:GeneralMed2._0     5      :controls%clr-namespace:GeneralMed2._0.Controls     5      $	��500��5	        N� Title$  PatientSearchPage��5       � 	Resources 5      %   GeneralMed2._0.CentralViewModel   CentralViewModel��%   &	          5   
   6!   5      .��5      � 
������� � DataContext# [  6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $	����6     FontAwesome#��[ 5        IconButtonForegroundMain#��[ 5      $��Center=�5      $
��Left=�5      $��24(�5       ��5!      �� *BackButtonCommand+�� 5#   
   $	����6   #��[ 5$      #��[ 5%      $��Center=�5&      $��Center=�5'      $��24(�5(      ��5)      �� *HomeCommand+� 5+   
   $��1��6   .+�5-      ��   RegularButton#��[ 6   $��Select Patient��5.      $��Right=�5/        ForegroundMainBrush#��[ 52      $��10q�53      $��20(�54      ��50      �� *SelectPatientCommand+��51      �� *SelectedPatient+54      �� 57      #��[ 6   $��Insert Patient��58      #��[ 59      $
��Left=�5:      $��10q�5;      $��20(�5<      ��5=      �� *InsertPatientCommand+5>      �� 5A   
   $��1q�6   $��2��5B      ��5C      �� 5D       �� 
StartPoint$	 1,0&�6&    �� EndPoint$	 0,1&�67   .��5E      �  � Color$ Transparent��6#    � Offset$	 0.0Q�67   � 5F        GrayUnderline# [ 6#   $
 0.25Q�6J   � 5G      # [ 6#   $
 0.75Q�6J   � 5H      $ Transparent��6#   $	 1.0Q�67   5I      5K      �� 5N   
   $��3��6   .+�5P      �  � ColumnDefinitions 5Q      �� 5R      $	��175 �6'   �� 5S      $	��185 �6'   �� 5T      $	��100 �6'   �� 5U      $	��100 �6'    5X      �� 5Y      $��* �6$   �� 5Z      $
��Auto �6$   .+�5]      ��   BaseTextBlock#��[ 6   $��	Last Name��5^      $��14(�5_      $��10 0 0 0q�5`      �� 5b      #��[ 6   $��
First Name��5c      $��1��5d      $��14(�5e      $��10 0 0 0q�5f      �� 5h      #��[ 6   $��Date of Birth��5i      $��2��5j      $��14(�5k      �� 5m      #��[ 6   $��Last Updated��5n      $��3��5o      $��14(�5p      $��5 0 0 2q�5q      �� 5s      $��1q�6   $��1��5t      $��4��5u      ��5v      �� 5w      $	 1,0&�6.   $	 0,1&�6?   .��5x      � $ Transparent��6+   $	 0.0Q�6?   � 5y      # [ 6+   $
 0.25Q�6R   � 5z      # [ 6+   $
 0.75Q�6R   � 5{      $ Transparent��6+   $	 1.0Q�6?   5|      5~      5�      �� 5�      -   5        	 ��Name$	 PatientList��5�      $��0q�5�      $	��Top=�5�      ��5�      �� *FilteredList+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� SelectedValue 5�      �� *SelectedPatient+��5�      �� 5�      .R�5�      4   .GeneralMed2._0.Controls.PatientListItemControl  5�      5�      5�      � 5�   
   $��4��6   .+�5�      �� -   5         ��Name$ UpdatePatientButton��5�      $��Update Patient��5�      $
��Left=�5�      #��[ 5�      $��20(�5�      #��[ 5�      ��5�      �� * OpenUpdatePatientWindowCommand+5�      �� 5�      -   5        $ DeletePatientButton��5�      $��Delete Patient��5�      $��20(�5�      #��[ 5�      $��Right=�5�      #��[ 5�      ��5�      �� *DeletePatientWindowCommand+5�      5�      5�      5�      