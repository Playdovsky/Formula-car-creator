   M S B A M L   `   `   `  ����?  ;Main, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Main.GUIMain.GUI  5          Main.GUI.StartControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:Main.GUI     5      .��5	      � .+�5
   
   �� -   5          ��Name$  
LabelTitle��5
      $��FORMULA CAR CREATOR��6$   $��Center=�6B   $��	0,170,0,0q�6_   $	��Top=�6r   
������ 
���  ��$
��Bold"�6�   $��48(�6�   $��Italic$�6�    � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6   .[�5      �� .��5      �� .��5      ��  �� TargetProperty$0 *(Label.Foreground).(SolidColorBrush.Color)�6-    �� From$	 RedX�6t   	 �� To$ OrangeX�6    g� Duration$ 0:0:1D�6�    g� AutoReverse .  g� RepeatBehavior$ Forever��6�   5      5      5      	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   ShadowDepth$
 5Q�6#      
BlurRadius$ 5Q�63   5      �� 5   
   -   5        $  LabelContinue��5      $��press mouse to continue��6'   $��Center=�6I   $��	0,444,0,0q�6f   $	��Top=�6y   5      5      