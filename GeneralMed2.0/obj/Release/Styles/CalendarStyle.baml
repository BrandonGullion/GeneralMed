   M S B A M L   `   `   `  ���� H  DGeneralMed2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:GeneralMed2._0.StylesGeneralMed2._0.Styles  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   MainCalendar  �� 
TargetType&    System.Windows.Controls.Calendar �� Property �� Value �� EndPoint �� 
StartPoint � Color � Offset �� 
TargetType ��Name5  /System.Windows.Controls.Primitives.CalendarItem	  Name
    CalendarItemStyle  MainCalendarItemStyle � 	Resources  ForegroundMainBrush  LatoRegular �Name � 	Resources  Key  GreenUnderline �� Color'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� Duration	 W� To �� TargetProperty �� 
TargetName �� CornerRadius � Cursor	 �� To J� Opacity �� Stretch ��Name  FontAwesome  FontSizeSmall �� Padding  IconHoverGreen ��Name � ColumnDefinitions � RowDefinitions  ��Name 	 PreviousButtonTemplate 
 HeaderButtonTemplate  NextButtonTemplate! ��Name  DisabledColor" �� RadiusY# �� RadiusX$ �� Triggers% P� Property& P� Value' �� 
TargetName( �� Value) �� Binding* �� RelativeSource+ �� AncestorType  MainCalendarButtonStyle:  4System.Windows.Controls.Primitives.CalendarDayButton,   Transitions%  System.Windows.VisualTransition-   GeneratedDuration. R� KeyTime/ R� Value  System.Windows.Visibility0 F�Name1 J� RenderTransformOrigin2 J� IsHitTestVisible�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     -local#clr-namespace:GeneralMed2._0.Styles  %  &	        &	     7  7  7  7  7  7  7  7  7  7  7  7  7  7  7 	 7 
 7  7  7  &	 �    �� "    .���  � �� �	#FF333333��  � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFE4EAF0��$ 0Q�� $ 	#FFECF0F4��$
 0.16Q�� $ 	#FFFCFCFD��$
 0.16Q�� $ 	#FFFFFFFF��$ 1Q���  � �� �� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFA3AEB9��$ 0Q�� $ 	#FF8399A9��$ 0.375Q�� $ 	#FF718597��$ 0.375Q�� $ 	#FF617584��$ 1Q���  � ��$ 1q���  � �� �� "   .R��� $ 	PART_Root��$��Center=�.+�  $	 PART_CalendarItem��#��z��#��z��#��z��#��z
 �� "   .���  � ��$ 0,3,0,3q���  � �� �� "   ���� (��       **(CalendarItem.DayTitleTemplateResourceKey+).R��� 8��  $	��9.5(�$
��Bold"�8�� $��Center=�$��0,6,0,6q�$��Center=����� .R�� $ 	PART_Root�� ���� DisabledColor 8     CommonStates��.   
Normal��  Disabled��. �� .��W� $ 0D�$ 1X�$ Opacity�$ PART_DisabledVisual��.+��� #��z��#��z��#��z��$ 1��._��� ���	#FFFFFFFF$��0q�$ 1��._��  ���� PreviousButtonTemplate " ��.R�� $ Arrow��   CommonStates��.   
Normal��  	MouseOver��. �� .���� $ 0D�8  $ Foreground.Color�$ 	LeftArrow��.+��� ���	#11E5EBF1$ 1Q�$
 Fill=�� .+��� $ 	LeftArrow��$	����8�� 8�� 8�� $
��Left=�$��Center=�$ 5q��� NextButtonTemplate " ��.R�� $ Arrow��   CommonStates��.   
Normal��  	MouseOver��. �� .���� $ 0D�8  $ Foreground.Color�$ 
RightArrow��.+��� ���	#11E5EBF1$ 1Q�$
 Fill=�� .+��� $ 
RightArrow��$	����8�� 8��	 8��
 $��Right=�$��Center=�$ 5q��� HeaderButtonTemplate " ��.R�� $ Arrow��   CommonStates��.   
Normal��  	MouseOver��. �� .���� $ 0D�8  $6 0(TextElement.Foreground).(SolidColorBrush.Color)�$ buttonContent��  Disabled��. �� .��W� $ 0D�$ .5X�$ Opacity�$ buttonContent��.+��� $ buttonContent��#��z��#��z��8�� 8�� $��0 3 0 0q�#��z��$��Center=� �� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $��* �.+��� $  PART_PreviousButton��$��0��|�.  $
��Left=�$��20��$��0��8�� $��28���� $  PART_HeaderButton��$��1��$
��Bold"�|�.  $
��10.5(�$��Center=�$��0��8�� $��Center=��� $  PART_NextButton��$��2��|�.  $��Right=�$��20��$��0��8�� $��28��� $ PART_MonthView��$��3��$��Center=�$��6,-1,6,6q�$��1��$y�Visible=� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �� $ PART_YearView��$��3��$��Center=�$��0 20 0 0q�$��1��$y�Hidden=� �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto � �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $! PART_DisabledVisual��8�� $ 0Q�$" 2��$# 2��$
 Fill=�8�� $��1��$y�	Collapsed=�$ P� % � {�& .  . ��� $' PART_DisabledVisual�� � y�$ Visible=��� $
( Year��) �� *DisplayMode+* �� *FindAncestor+"+   .a��� $' PART_MonthView�� � y�$ Hidden=��� $' PART_YearView�� � y�$ Visible=��� $( Decade��) �� *DisplayMode+* �� *FindAncestor+"+   .a��� $' PART_MonthView�� � y�$ Hidden=��� $' PART_YearView�� � y�$ Visible=��� "   .���  � ��$ 5����  � ��$ 5����  � ��$ 10(���  � ��$ 0 0 10 0q���  � ��$ 30����  � ��$ 30����  � ��$ Right=���  � ��$	 Top=���  � �� �� "  .R��    CommonStates��,   $- 0:0:0.1D�.   
Normal��  	MouseOver��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Pressed��. �� .��W� $ 0D�$	 0.5X�$ Opacity�$ HighlightBackground��  Disabled��. �� .��W� $ 0D�$ 0X�$ Opacity�$ HighlightBackground��W� $ 0D�$	 .35X�$ Opacity�$ 
NormalText��  SelectionStates��,   $- 0D�.   
Unselected��  Selected��. �� .��W� $ 0D�$	 .75X�$ Opacity�$ SelectedBackground��  CalendarButtonFocusStates��,   $- 0D�.   CalendarButtonFocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $. 0��/  Visible=�  CalendarButtonUnfocused��. �� .��T� $ 0D�$ 
Visibility�$ DayButtonFocusVisual��..�i� $. 0��/  	Collapsed=�  ActiveStates��,   $- 0D�.   
Active��  Inactive��. �� .���� $ 0D�$ 	#FF777777X�$6 0(TextElement.Foreground).(SolidColorBrush.Color)�$ 
NormalText��  	DayStates��,   $- 0D�.   
RegularDay��  	Today��. �� .��W� $ 0D�$ 1X�$ Opacity�$ TodayBackground���� $ 0D�$ 	#FFFFFFFFX�$6 0(TextElement.Foreground).(SolidColorBrush.Color)�$ 
NormalText��  BlackoutDayStates��,   $- 0D�.   	NormalDay��  BlackoutDay��. �� .��W� $ 0D�$ .2X�$ Opacity�$ Blackout��.+��� $! TodayBackground�����	#FFAAAAAA$ 0Q�$" 1��$# 1���� $! SelectedBackground�����	#FFBADDE9$ 0Q�$" 1��$# 1���� #��z��#��z��#��z���� $! HighlightBackground�����	#FFBADDE9$ 0Q�$" 1��$# 1���� $ 
NormalText�����	#FF333333$��0 2 4 0q�#��z��#��z��F� $0 Blackout��}�����5 �Z @�J� �Q2� �J� �̉� iV� �A�� �J� �W�� �J� ѷ�� #�� �>8� 7T�K�� 7T�� � ��� ћ�� 7T����G @7T��� �D� 	���	#FF000000$��Stretch=�$��3q�$ 0Q�$1 0.5,0.5&�$
 Fill=�$��Stretch=��� $! DayButtonFocusVisual��2 .  $" 1��$# 1�����	#FF45D6FA$y�	Collapsed=�