   M S B A M L   `   `   `  ����H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:GeneralMed2._0GeneralMed2._0  5   	   0    *GeneralMed2._0.Windows.InsertPatientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:GeneralMed2._0     5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterOwner=�5   	    � Title$ InsertPatientWindow��5   	   $	��500��6%   $	��400��62    � 	Resources 5      %   GeneralMed2._0.CentralViewModel   CentralViewModel��%   &	          5   
   6!   5      .��5      �  � DataContext# [  6   .+�5   
   ��  �� Padding$ 15q�6    �� CornerRadius$ 20��5      
�������$	��1.5q�5        ForegroundLightBrush#��[ 5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$   .+�5"      �� $��0��6   .+�5#      �� -   5        $��30��5#      $��	0 -10 0 0q�5$      
������ ._�5(      � 	 � ColumnDefinitions	 5)      �� 5*   "   $��* �63   �� 5+   "   $
��Auto �63   .+�5.      �� $��Insert Patient��6(     ForegroundMainBrush#��[ 5/   (   $��18(�50   (   �� 52      -   5        $��1��52   %   $��[ X ]��53   %   $��Calibri)�54   %   #��[ 55   %     IconButtonForegroundMain#��[ 56   %   $��Right=�57   %   $��20(�58   %   $��0,0,5,0q�63   6D   59      5:      5>      �� 5@      $��1��6   .+�5B      �� $��First Name:��6      BaseTextBlock#��[ 5C       $��20(�5D       �� 5F      -   5        
 ��Name$
 FirstNameTextBox��5G        UnderlineTextBox#��[ 5F      $��20(�5H      #��[ 5I      $��0 0 0 5q�5J      �� 5L      $��
Last Name:��6    #��[ 5M       $��20(�5N       �� 5P      -   5        $
 LastNameTextBox��5Q      #��[ 5P      $��20(�5R      #��[ 5S      $��0 0 0 5q�5T      �� 5V      $!��Date Of Birth (DD/MM/YYYY):��6    #��[ 5W       $��20(�5X       �� 5Z      -   5        $
 
DOBTextbox��5[      $��24(�5Z      #��[ 5\      #��[ 5]      $��0 0 0 5q�5^      �� 5`      $��Room/Address��6    #��[ 5a       $��20(�5b       �� 5d      -   5        $
 AddressTextbox��5e      $��24(�5d      #��[ 5f      #��[ 5g      $��0 0 0 5q�5h      5k      �� 5m      -   5         ��Name$ 
SaveButton��5o      $��2��5m      $
��Save��5n      $��Bottom=�5q      $��Right=�5r      $��24(�5s        RegularButton#��[ 5t      5u      5v      5w      5x      