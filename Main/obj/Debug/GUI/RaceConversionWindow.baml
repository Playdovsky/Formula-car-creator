   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Main.GUIMain.GUI  5   	   #    Main.GUI.RaceConversionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Main.GUI     5   	     � Title$  Conversion to race car��5   	   $	��400��6(   $	��300��65    � 
ResizeMode$ NoResize=�6A    � Icon$ ../Resources/logo.ico��6W   .��5	      � .+�5
   
   �� -   5         ��Name$ TextBoxBrakes��5
      $
��Left=�6)   $��24��6D   $��173,103,0,0q�6P    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $��40��6�    �� 	MaxLength$ 4��6�   
���   �6�   �� 5   
   -   5        $ TextBoxMaxSpeed��5      $
��Left=�6+   $��26��6F   $��
173,43,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $��40��6�   $ 3��6�   
���   �6�   �� 5   
   -   5        $ TextBoxAcceleration��5      $
��Left=�6/   $��24��6J   $��
173,74,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $��40��6�   $ 3��6�   
���   �6�   �� 5   
   -   5         ��Name$ CheckBoxFIA��5      $��Approved by FIA��6(   $
��Left=�6B   $��23��6]   $��
10,150,0,0q�6i   $	��Top=�6}   $	��120��6�   
���   �6�   �� 5   
   -   5         ��Name$ LabelMaxSpeed��5      $��Max speed (km/h)��6'   $��	10,43,0,0q�6B   $	��Top=�6U   $
��Left=�6m   �� 5   
   -   5        $ LabelAcceleration��5      $��Acceleration (0-100km)��6+   $��	10,73,0,0q�6L   $	��Top=�6_   $
��Left=�6w   �� 5   
   -   5        $ LabelBrakes��5      $��Brakes balance (in %)��6%   $��
10,102,0,0q�6E   $	��Top=�6Y   $
��Left=�6q   �� 5   
   -   5         ��Name$ ButtonConvert��5      $��Convert��6(   $
��Left=�6:   $��30��6U   $��
10,322,0,0q�6a   $	��Top=�6u   $	��120��6�   ���	#FFB50000
�������$
��Bold"�6�   
���   ���5      �� 5      	 �� 
TargetType"	 ��6"   .R�5      �� 
 ��Name$
 border��6   
���   �#��z��6A   ._�5      �� $��Center=�6+   $��Center=�6H   5       �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value . . �5      ��  �� 
TargetName$ border��6%    �� Property � �� �� Value
 �  ��6O   5      5      5      5      5       