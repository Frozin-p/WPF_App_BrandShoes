   M S B A M L   `   `   `  ���� B  >MyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MyStoreMyStore      MyStore.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:MyStore     _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Регистрация��$��1920 ��$
��1080�� � WindowStyle$ ThreeDBorderWindow=�.��� ���	#ffdadada.+��� $	��400��$	��400��$��15q�
�������$��Center=� �� Padding$ 30q�$	��700��$	��650�� �� CornerRadius$ 20�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 30Q�   Color$
 Gray��   ShadowDepth$ 0Q�._��� .+��� $��Здравствуйте!��$��40(�$
��Bold"�$��0 0 0 50q�� $��0 0 0 20q�.+��� $
��Left=�$��Регистрация��$	��200��$��50��
����p��$��18(��� -   $��Right=�$��
Войти��$	��200��$��50��   MaterialDesignFlatButton#��[  
�������$��18(��� -    ��Name$ textBoxLogin��)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введите логин�� % !MaterialDesignFloatingHintTextBox#��[ $��50��$��16(�G� -   
 G�Name$
 passBox��$!	 Введите пароль�� ) %MaterialDesignFloatingHintPasswordBox#��[ $��50��$��16(�G� -   $
 passBox2��$%	 Повторите пароль��#��[ $��50��$��16(��� -   $ textBoxEmail��$	 Email��#��[ $��50��$��16(��� -   $*��$Зарегестрироваться��$
��0 25q�$	��100��$��30(�