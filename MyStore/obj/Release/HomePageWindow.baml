   M S B A M L   `   `   `  ���� B  >MyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MyStoreMyStore      MyStore.HomePageWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MyStore     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$%  Главная страница��$��1920 ��$
��1080�� � WindowStyle$ ThreeDBorderWindow=�.��� 
������� � RowDefinitions �� �� �� �� �� �� �� ��  � ColumnDefinitions �� �� �� �� .+��� $��7��$��4��
��������� -    ��Name$ Account��$	��150��$	��150��$��3��$��7��$��Center=�$��Center=���Z� ��Z� ��Z� .���� $	��120��$	��120��$'��!/PNG/Account-User-PNG-Clipart.png��$��3��$��7��$��Center=�$��Center=��� -   $
 Cart��$	��150��$	��150��$��2��$��7��$��Center=�$��Center=���Z� ��Z� ��Z� .���� $	��120��$	��120��$��/PNG/cart.png��$��2��$��7��$��Center=�$��Center=��� -   $ 
Favourites��$	��150��$	��150��$��1��$��7��$��Center=�$��Center=���Z� ��Z� ��Z� .���� $	��120��$	��120��$��	/Like.png��$��7��$��1��$��Center=�$��Center=��� -   $
 Home��$	��150��$	��150��$��0��$��7��$��Center=�$��Center=���Z� ��Z� ��Z� .���� $	��120��$	��120��$��/PNG/Home.png��$��7��$��0��$��Center=�$��Center=��� $��4��.+��� -   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Поиск�� %  !MaterialDesignFloatingHintTextBox#��[  $��30(��� $��1��$��6��$��4��
�������$y�Visible=�.���� $y�Visible=�.+�� -    �Name$ VansGrid��$	��250��$	��250��
�������$
��0 10q� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�	   Color$
	 Gray��
   ShadowDepth$
 0Q�.+��� $��/PNG/Vans.jpeg��$
��Left=��� -   $ 
VansButton��$	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ .���� $��/PNG/cart.png��$��80��$��80��$��Center=�$��Center=��� $	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ $��	0 0 120 0q�.���� $��/PNG/Like.png��$��80��$��80��$��Center=�$��Center=��� -    ��Name$ 	textBox_1��$	��140��$	��Top=�$
��Wrap=�$��	300 0 0 0q�$��50(�$��SemiBold"��� -	   $��Bottom=�$��0 0 0 20q�$��80��$	��250��  MaterialDesignFlatButton#��[ $$��Перейти к товару��$��25(�$
��Bold"�� -
   $ DunkGrid��$	��250��$	��250��
�������$
��0 10q�   $ 10Q�$
	 Gray��$
 0Q�.+��� $��/PNG/SBDunk.jpeg��$
��Left=��� -   $ 
DunkButton��$	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ .���� $��/PNG/cart.png��$��80��$��80��$��Center=�$��Center=��� $	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ $��	0 0 120 0q�.���� $��/PNG/Like.png��$��80��$��80��$��Center=�$��Center=��� -   $ 	textBox_2��$	��140��$	��Top=�$��	300 0 0 0q�$��50(�$��SemiBold"��� -   $��Bottom=�$��0 0 0 20q�$��80��$	��250��#��[ $$��Перейти к товару��$��25(�$
��Bold"�� -   $ 	SambaGrid��$	��250��$	��250��
�������$
��0 10q�   $ 10Q�$
	 Gray��$
 0Q�.+�� .+��� $��/PNG/Samba.jpg��$
��Left=��� -   $ SambaButton��$	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ .���� $��/PNG/cart.png��$��80��$��80��$��Center=�$��Center=��� $	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ $��	0 0 120 0q�.���� $��/PNG/Like.png��$��80��$��80��$��Center=�$��Center=��� -   $ 	textBox_3��$	��140��$	��Top=�$��	300 0 0 0q�$��50(�$��SemiBold"��� -   $��Bottom=�$��0 0 0 20q�$��80��$	��250��#��[ $$��Перейти к товару��$��25(�$
��Bold"�� -   $ RSZGrid��$	��250��$	��250��
�������$
��0 10q�   $ 10Q�$
	 Gray��$
 0Q�.+�� .+��� $��/PNG/RSZ.jpg��$
��Left=��� -   $ 	RSZButton��$	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ .���� $��/PNG/cart.png��$��80��$��80��$��Center=�$��Center=��� $	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ $��	0 0 120 0q�.���� $��/PNG/Like.png��$��80��$��80��$��Center=�$��Center=��� -   $ 	textBox_4��$	��140��$	��Top=�$��	300 0 0 0q�$��50(�$��SemiBold"��� -   $��Bottom=�$��0 0 0 20q�$��80��$	��250��#��[ $$��Перейти к товару��$��25(�$
��Bold"�� -   $ OcaiGrid��$	��250��$	��250��
�������$
��0 10q�   $ 10Q�$
	 Gray��$
 0Q�.+�� .+��� $��/PNG/ocai.jpg��$
��Left=��� -   $ 
OcaiButton��$	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ .���� $��/PNG/cart.png��$��80��$��80��$��Center=�$��Center=��� $	��115��$	��115��$��Right=�$��Bottom=�
������ 
������ 
������ $��	0 0 120 0q�.���� $��/PNG/Like.png��$��80��$��80��$��Center=�$��Center=��� -   $ 	textBox_5��$	��140��$	��Top=�$��	300 0 0 0q�$��50(�$��SemiBold"��� -   $��Bottom=�$��0 0 0 20q�$��80��$	��250��#��[ $$��Перейти к товару��$��25(�$
��Bold"�