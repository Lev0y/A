   M S B A M L   `   `   `  ����F  BEMailClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EMailClientEMailClient  5   	       EMailClient.Letter   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:EMailClient     5   	     � Title$  Письмо��5   	   $	��450��6   $	��800��6%   .��5
      � 
������.+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��26��6.   $��
10,10,10,0q�6:   
�������$��Stretch=�6a   $	��Top=�6   .+�5      �� -   5         ��Name$ SaveMessage��5      $��16��6*   $��5,5,0,0q�65   $
��Left=�6F   $��16��6a   $	��Top=�6m   .��5      �� $��save.png��6   5      �� 5      -   5        $ DeleteMessage��5      $��16��6,   $��16��67   $��5,5,0,0q�6C   $	��Top=�6T   $
��Left=�6l   .��5      �� $��
delete.png��6   5      5      �� 5   
   -   5        $��MessageInfo��5      $��70��6%   $��
10,46,10,0q�61   $��Stretch=�6E   $	��Top=�6c    �� TextWrapping$ WrapWithOverflow=�6{    �� 
IsReadOnly . 6�   (  "System.Windows.Controls.WebBrowser  5   
   -   5        $��mb��5      $��10,126,10,10q�6   $��Stretch=�65   $��Stretch=�6S   5      5      