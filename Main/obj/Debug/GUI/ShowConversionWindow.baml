   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MainMain  5   	       Main.ShowConversionWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Main     5   	     � Title$  Conversion to show car��5   	   $	��400��6(   $	��300��65    � 
ResizeMode$ NoResize=�6A    � Icon$ ../Resources/logo.ico��6W   .��5	      � .+�5
   
   �� $��Advertisers��6   $
��Left=�6&   $��	10,15,0,0q�6A   $	��Top=�6T   �� 5   
   -   5         ��Name$ TextBoxAdvertiser��5      $
��Left=�6-   $��	10,41,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $	��Top=�6o   $	��180��6�   $��45��6�   
���   �6�   �� 5   
   -   5         ��Name$ CheckBoxForSale��5      $��For sale��6,   $
��Left=�6?   $��
10,177,0,0q�6Z   $	��Top=�6n   $��64��6�   
���   �6�   �� 5   
   -   5         ��Name$ ButtonConvert��5      $��Convert��6(   $
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
   $��Where is located:��6   $
��Left=�6,   $��	10,98,0,0q�6G   $	��Top=�6Z   �� 5   
   -   5        $ TextBoxLocation��5      $
��Left=�6+   $��
10,124,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��180��6�   $��30��6�   
���   �6�   �� 5   
   -   5         ��Name$ 
LabelPrice��5      $��Price (in USD):��6$   $
��Left=�6>   $��
10,213,0,0q�6Y   $	��Top=�6m   $y�Hidden=�6�   �� 5   
   -   5        $ TextBoxPrice��5      $
��Left=�6(   $��
10,239,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   $y�Hidden=�6�   
���   �6�   5       5!      