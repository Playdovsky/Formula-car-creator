   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5   	   !    Main.DamageConversionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Main     5   	     � Title$  Conversion to damaged car��5   	   $	��400��6+   $	��300��68    � 
ResizeMode$ NoResize=�6D    � Icon$ ../Resources/logo.ico��6Z   .��5	      � .+�5
   
   �� -   5         ��Name$ TextBoxReasonConversion��5
      $
��Left=�63   $��	10,38,0,0q�6N    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��207��6�   $��80��6�   
���   �6�   �� 5   
   -   5        $ TextBoxDamagedComponents��5      $
��Left=�64   $��
10,149,0,0q�6O   $
 Wrap=�6c   $	��Top=�6w   $	��207��6�   $��59��6�   
���   �6�   �� 5   
   -   5         ��Name$ CheckBoxCanBeFixed��5      $��Can be fixed��6/   $��10,227,186,0q�6F   $	��Top=�6\   $��15��6t   
���   �6�   �� 5   
   -   5         ��Name$ ButtonConvert��5      $��Convert��6(   $
��Left=�6:   $��30��6U   $��
10,322,0,0q�6a   $	��Top=�6u   $	��120��6�   ���	#FFB50000
�������
���   �$
��Bold"�6�   ��5      �� 5       �� 
TargetType" ��6"   .R�5      ��  ��Name$ border��6   
���   �#��z��6A   ._�5      �� $��Center=�6+   $��Center=�6H   5      	 �� Triggers	 5      P� 5      
 P� Property
 �@J�IsMouseOver P� Value . . �5      ��  �� 
TargetName$ border��6%    �� Property � �� �� Value
 �  ��6O   5      5      5      �� 5   
   -   5         ��Name$ LabelDamagedComponents��5      $��Damaged components:��60   $
��Left=�6N   $��
10,123,0,0q�6i   $	��Top=�6}   �� 5   
   $$��Why has been damaged (reason):��6   $
��Left=�69   $��	10,12,0,0q�6T   $	��Top=�6g   �� 5   
   -   5        $ TextBoxRepairTime��5      $
��Left=�6-   $��
10,282,0,0q�6H   $
 Wrap=�6\   $	��Top=�6p   $	��120��6�   $��18��6�   $y�Hidden=�6�   
���   �6�   �� 5   
   -   5        $ LabelRepairTime��5      $��Repair time (in hours):��6)   $
��Left=�6K   $��
10,256,0,0q�6f   $	��Top=�6z   $��26��6�   $	��126��6�   $y�Hidden=�6�   5      5       