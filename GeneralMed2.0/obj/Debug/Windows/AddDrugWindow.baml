   M S B A M L   `   `   `  ����H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:GeneralMed2._0.WindowsGeneralMed2._0.Windows  5   	   /clr-namespace:GeneralMed2._0GeneralMed2._0  5   	   *    $GeneralMed2._0.Windows.AddDrugWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:GeneralMed2._0.Windows     5   	   /local2clr-namespace:GeneralMed2._0     5   	   -   5          �Name$  _AddDrugWindow��5	   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������  � Title$ AddDrugWindow��5   	   $	��400��6   $	��800��6,    � 	Resources 5      +   %GeneralMed2._0.AddDrugWindowViewModel   vm��%   &	          5   
   6(   5      .��5      � .+�5   
   ��  �� Padding$ 15q�6    �� CornerRadius$ 20��5      
�������$	��1.5q�5        ForegroundLightBrush#��[ 5      ._�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $
��Auto �6$    � ColumnDefinitions 5#      �� 5$      $��* �6'   �� 5%      $
��Auto �6'   �� 5&      $��* �6'   .+�5+      �� -   5        $��30��5+      $��	0 -10 0 0q�5,      
������ $��3��5/      ._�51      �  52      �� 53      $��* �6/   �� 54      $
��Auto �6/   .+�57      �� $��Drug Settings��6$     ForegroundMainBrush#��[ 58   $   $��18(�59   $   �� 5<      -   5        $��2��5<   !   $��[ X ]��5=   !   $��Calibri)�5>   !   #��[ 5?   !     IconButtonForegroundMain#��[ 5@   !   $��Right=�5A   !   $��20(�5B   !   $��0,0,5,0q�6/   5C   !   5F      5G      �� 5L      $��1��6   .+�5N      �� $��	Add Drug:��6      BaseTextBlock#��[ 5O       $��20(�5P       �� 5R      $��
Drug Name:��6    #��[ 5S       $��18(�5T       �� 5V      -   5        	 ��Name$	 FirstNameTextBox��5W        UnderlineTextBox#��[ 5V      $��18(�5Y      #��[ 5Z      $��0 0 0 5q�5[      ��5X      �� *
DrugName+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=�5[      �� 5]      $��General Purpose:��6    #��[ 5^       $��20(�5_       �� 5a       �� DisplayMemberPath$ 
GeneralUse��5b      $��0 0 0 1q�5c       �� 
IsEditable . #��[ 5e      $��16(�5f      ��5a      �� *GeneralUseList+ �� SelectedValue 5g      �� *LeftGeneralUse+$ TwoWay=�$
 PropertyChanged=��� 5i        RegularButton#��[ 6   $
��Save��5j      $��Center=�5l      #��[ 5m      $��20(�5n      ��5k      �� *SaveNewDrugCommand+5n      5o      �� 5u      $��2q�6   $��2��5v      $��1��5w      $��4��5x      $��5q�5y      ��5z      �� 5{       �� 
StartPoint$	 0,0&�6.    �� EndPoint$	 1,1&�6?   .��5|      �  � Color$ Transparent��6+    � Offset$	 0.0Q�6?   � 5}        GrayUnderline# [ 6+   $
 0.25Q�6R   � 5~      # [ 6+   $
 0.75Q�6R   � 5      $ Transparent��6+   $	 1.0Q�6?   5�      5�      � 5�      $��1��6   $��2��5�      .+�5�      �� $ 5 0 0 0q�6   ._�5�      �� .+�5�      �� $��Update Drug:��6(   $��20(�5�   (   #��[ 5�   (   �� 5�      #��[ 6(   #��[ 5�   (   $��14(�5�   (   $+��%Select desired drug to edit or delete��5�   (   �� 5�      $��0 0 0 1q�5�   '    . $ DrugName��5�   '   #��[ 5�   '   $��16(�5�   '   ��5�   '   �� *DrugModelList+ �� SelectedItem 5�   '   �� *SelectedUpdate+$ TwoWay=�$
 PropertyChanged=��� 5�      $��
Drug Name:��6(   #��[ 5�   (   $��18(�5�   (   �� 5�      #��[ 6&   $��18(�5�   &   #��[ 5�   &   $��0 0 0 5q�5�   &   ��5�   &   �� *SelectedUpdate.DrugName+$
 PropertyChanged=�$ TwoWay=�5�   &   �� 5�      $��General Purpose:��6(   #��[ 5�   (   $��18(�5�   (   �� 5�      $ 
GeneralUse��5�   '    . $��0 0 0 1q�5�   '   #��[ 5�   '   $��16(�5�   '   ��5�   '   �� *GeneralUseList+ 5�   '   �� *SelectedItem.General+ 5�   '   �� *RightGeneralUse+$ TwoWay=�$
 PropertyChanged=�� 5�      
������  5�   "   �� 5�   &   $
��257* �67   �� 5�   &   $
��115* �67   .+�5�   "   �� $��Delete��6)   #��[ 5�   )   $��16(�5�   )   $
��Left=�5�   )   $��5,5,0,5q�6D   ��5�   )   �� *DeleteSelectedDrugCommand+5�   D   �� 5�   "   $��Update��6)   #��[ 5�   )   $��16(�5�   )   $��Right=�5�   )   $��1��6E   $��0,5,5,5q�6U   ��5�   )   �� *UpdateSelectedDrugCommand+5�   U   5�      5�      5�      5�      5�      5�      5�      5�      