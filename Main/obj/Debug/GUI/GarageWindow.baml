   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5   	       Main.GarageWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Main     5   	     � Title$  Garage��5   	   $	��345��6   $	��623��6%    � 
ResizeMode$ NoResize=�61    � Icon$ ../Resources/logo.ico��6G   .��5	      � $��0,0,0,-6q�6    � RowDefinitions 5
   
   �� 5      $	��16* �6   �� 5      $
��319* �6    � ColumnDefinitions 5   
   �� 5      $
��465* �6   �� 5      $
��158* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridCars��5      $��Center=�6)   $	��285��6F   $	��Top=�6S   $	��432��6k      
IsReadOnly .    SelectionMode$ Single=�6�      AutoGenerateColumns .  $	   HorizontalScrollBarVisibility$	 Disabled=�6  $��0,1,0,0q�6A  $��1��6R  
���   �
�������
   HorizontalGridLinesBrush

 �   �   VerticalGridLinesBrush
 �   �   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Unqiue number��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *Number+  5      $ Formula��6%    66   �� *Type+  5      $ Engine��6%    65   �� *Engine+ � 	Resources 5       �� Color��%Z   (��       5   "   * SystemColors.HighlightBrushKey+)�� 6   $ 	#FFB50000��5      5      5      �� 5   
   -   5         ��Name$ ButtonConvert��5      $��Damaged car��6(   $��	0,107,0,0q�6>   $��0q�6Q   $	��Top=�6]   $��30��6u   $��1��6�   $��1��6�    �� IsCancel . $��Center=�6�   $	��138��6�   ���	#FFB50000
�������$
��Bold"�6$  
���   ���5      �� 5       �� 
TargetType" ��6"   .R�5       ��  ��Name$ border��6   
���   �#��z��6A   ._�5!      �� $��Center=�6+   $��Center=�6H   5"       �� Triggers 5#      P� 5$       P� Property �@J�IsMouseOver P� Value . . �5%      ��  �� 
TargetName$ border��6%    �� Property � �� �� Value
 �  ��6O   5&      5(      5*      �� 5+   
   -   5        $ ButtonDelete��5+      $��Delete��6'   $��	0,256,0,0q�68   $��1��6K   $	��Top=�6X   $��30��6p   $��1��6�   $��Center=�6�   $	��138��6�   ���	#FFB50000
�������$
��Bold"�6�   
���   ���5,      �� 5-      " ��6"   .R�5.      �� $ border��6   
���   �#��z��6A   ._�5/      �� $��Center=�6+   $��Center=�6H   50       51      P� 52       �@J�IsMouseOver . . �53      �� $ border��6%    � ��
 �  ��6O   54      56      58      �� 59   
   -   5         ��Name$ LabelConvert��59      $��Convert to...��6&   $��0,1,0,0q�6>   $��1��6O   $��1��6\   $��16(�6l   $
��Bold"�6z   $��Center=�6�   $	��Top=�6�   �� 5:   
   -   5        $ ButtonRefresh��5:      $��1��6(   $��Refresh��68   $��Center=�6J   $��	0,221,0,0q�6g   $��1��6z   $	��Top=�6�   $	��138��6�   $��30��6�   ���	#FFB50000
�������$
��Bold"�6�   
���   ���5;      �� 5<      " ��6"   .R�5=      �� $ border��6   
���   �#��z��6A   ._�5>      �� $��Center=�6+   $��Center=�6H   5?       5@      P� 5A       �@J�IsMouseOver . . �5B      �� $ border��6%    � ��
 �  ��6O   5C      5E      5G      �� 5H   
   -   5        $ ButtonConvertShow��5H      $��Show car��6,   $��0,72,0,0q�6?   $��0q�6Q   $	��Top=�6]   $��30��6u   $��1��6�   $��1��6�    . $��Center=�6�   $	��138��6�   ���	#FFB50000
�������$
��Bold"�6!  
���   ���5I      �� 5J      " ��6"   .R�5K      �� $ border��6   
���   �#��z��6A   ._�5L      �� $��Center=�6+   $��Center=�6H   5M       5N      P� 5O       �@J�IsMouseOver . . �5P      �� $ border��6%    � ��
 �  ��6O   5Q      5S      5U      �� 5V   
   -   5        $ ButtonConvertRace��5V      $��1��6,   $��Race car��6<   $��Center=�6O   $��30��6l   $��0,37,0,0q�6x   $��1��6�   $	��Top=�6�   $	��138��6�   ���	#FFB50000
�������$
��Bold"�6  
���   ���5W      �� 5X      " ��6"   .R�5Y      �� $ border��6   
���   �#��z��6A   ._�5Z      �� $��Center=�6+   $��Center=�6H   5[       5\      P� 5]       �@J�IsMouseOver . . �5^      �� $ border��6%    � ��
 �  ��6O   5_      5a      5c      5d      5e      