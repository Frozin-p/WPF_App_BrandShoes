   M S B A M L   `   `   `  ����B  >MyStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MyStoreMyStore  5   	       MyStore.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:MyStore     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  Регистрация��5	   	   $��1920 ��6   $
��1080��6,    � WindowStyle$ ThreeDBorderWindow=�69   .��5
      � ���	#ffdadada.+�5   
   �� $	��400��6   $	��400��6    $��15q�60   
�������$��Center=�6O    �� Padding$ 30q�6j   $	��700��6w   $	��650��6�    �� CornerRadius$ 20��6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$
 Gray��63      ShadowDepth$ 0Q�6@   ._�5      �� .+�5      �� $��Здравствуйте!��6   $��40(�61   $
��Bold"�6?   $��0 0 0 50q�6Q   � 5      $��0 0 0 20q�6   .+�5      �� $
��Left=�6   $��Регистрация��68   $	��200��6N   $��50��6Z   
����p��$��18(�6�   �� 5      -   5        $��Right=�5      $��
Войти��69   $	��200��6j   $��50��6v      MaterialDesignFlatButton#��[  6�   
�������$��18(�6�   5      �� 5      -   5         ��Name$ textBoxLogin��5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Введите логин��60    % !MaterialDesignFloatingHintTextBox#��[ 6_   $��50��6�   $��16(�6�   G� 5      -   5        
 G�Name$
 passBox��5      $!	 Введите пароль��6/    ) %MaterialDesignFloatingHintPasswordBox#��[ 6_   $��50��6�   $��16(�6�   G� 5      -   5        $
 passBox2��5      $%	 Повторите пароль��60   #��[ 6b   $��50��6�   $��16(�6�   �� 5      -   5        $ textBoxEmail��5      $	 Email��60   #��[ 6W   $��50��6�   $��16(�6�   �� 5      -   5        $*��$Зарегестрироваться��5      $
��0 25q�66   $	��100��6D   $��30(�6Q   6_   5      5      5      5      