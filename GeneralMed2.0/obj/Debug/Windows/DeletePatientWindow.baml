   M S B A M L   `   `   `  ����H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:GeneralMed2._0.WindowsGeneralMed2._0.Windows  5   	   0    *GeneralMed2._0.Windows.DeletePatientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:GeneralMed2._0.Windows     5   	     � AllowsTransparency  . 
������  � WindowStyle$
 None=�5
   	    � Title$ DeletePatientWindow��5   	   $	��200��6%   $	��400��62   .��5      � .+�5   
   ��  �� Padding$ 15q�6    �� CornerRadius$ 20��5      
�������$	��1.5q�5         ForegroundLightBrush#��[  5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   .+�5      �� -   5         ��Name$ WindowHeader��5      $��0��5      $��	0 -15 0 0q�5      ._�5      � .+�5      �� $��Delete Selected Patient��6$     BaseTextBlock#��[ 5    $   $��20(�5!   $   �� 5$      -   5        $��[ X ]��5$   !     RegularButton#��[ 5%   !   $��Right=�5&   !   $��20(�5'   !   $��0��5(   !   5)   !   5*      5,      � 5.      $��1��6    50      �� 51      $
��Auto �6(   �� 52      $��2 �6(   �� 53      $��* �6(   .+�56      �� #��[ 6    $��0��57       $]��WDeleting patient will remove all related drug lists, are you sure you want to continue?��58       $	��Top=�59       $
��Wrap=�5:       $��16(�5;       �� 5=      $��2q�6   $��1��5>      ��5?      �� 5@       �� 
StartPoint$	 0,0&�62    �� EndPoint$	 1,1&�6C   .��5A   "   � 	 � Color$	 Transparent��6/   
 � Offset$	
 0.0Q�6C   � 5B   "     GrayUnderline#	 [ 6/   $

 0.25Q�6V   � 5C   "   #	 [ 6/   $

 0.75Q�6V   � 5D   "   $	 Transparent��6/   $	
 1.0Q�6C   5E      5G      �� 5I      -   5         ��Name$ ConfirmButton��5P      $��Center=�5I      $��2��5J      $��Center=�5K      $	��Yes��5L      $��	0 0 150 0q�5M      $��25(�5N      #��[ 5O      5Q      �� 5R      -   5        $ CancelButton��5X      $��Center=�5R      $��2��5S      $��Center=�5T      $��No��5U      $��	150 0 0 0q�5V      $��25(�5W      #��[ 5Z      5[      5]      5a      5b      5d      