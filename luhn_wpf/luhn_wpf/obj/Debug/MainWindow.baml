   M S B A M L   `   `   `  ����  luhn_wpf    luhn_wpf.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   f bDevExpress.Printing.v17.2.Core, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49ahCustom[http://schemas.devexpress.com/winfx/2008/xaml/printingcore/xtraprinting/native/presentation  6G     � Title$  
MainWindow��5   	   $	��351��6   $	��527��6)   .��5      � .+�5   
   �� -   5         ��Name$ Girdi��5      $
��Left=�6!   $��22��6<   $��
158,48,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��165��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�    � ToolTip$ Kart Numarasını girin��6�    �� 	IsEnabled . .��6  z�5      V� 5	      .~�5
      �� �� 5      �� 5       �� Angle$ -0.097Q�6&   T� 5      5      .��5   '   5      �� 5   
   $��Kart Numarasını Girin: ��6   $
��Left=�62   $��27��6M   $��	26,44,0,0q�6Y   $	��Top=�6l   $	��127��6�   &   DevExpress.Xpf.Core.SimpleButton  5   
   -   5          Name$ 
Check_Card��5      $��
Kontrol Et��6.   $
��Left=�6C   $��27��6^   $��
330,44,0,0q�6j   $	��Top=�6~   $	��133��6�   $ 
Kontrol Et��6�    �� 	IsDefault . 	   Glyph	 6�   *  $DevExpress.Xpf.Core.DXImageExtension  
   Image1  +DevExpress.Xpf.Core.Native.DXImageConverter$
 Apply_32x32.png  � ContextMenu 5      �� 5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   -   5         ��Name$ girilenKartNo��5      $
��Left=�6+   $��32��6F   $��
82,119,0,0q�6R   $
��Wrap=�6f   $	��Top=�6z   $	��288��6�   $��14(�6�   �� 5   
   -   5         ��Name$ gecerli��5      $��347,118,138,169q�6!   $��Apply_32x32.png��6:   $
��Fill=�6S   �� 5   
   -   5        $ gecersiz��5      $��347,117,138,170q�6"   $��Cancel_32x32.png��6;   $
��Fill=�6U   5      5       