   M S B A M L   `   `   `  ����F  BEMailClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:EMailClientEMailClient  5   	       EMailClient.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:EMailClient     5   	     � Title$  EMailClient��5   	   $	��450��6   $	��800��6*   $	��600��66   $	��300��6E   .��5
      � -   5        $��MainGrid��5
       � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      $	��89* �6   .+�5   
   � -   5        $
��Menu��5      
������$��70��63   $
��Left=�6>   .+�5      �� -   5        $��bWriteLetter��5   A   $��0q�6   
������$��60��6U   $��60��6`   $��5,5,5,0q�6l      ButtonStyle1#���   6�   $	��Top=�6�   .��5      �� $��write_letter.png��6   5      �� 5      -   5        $��bListOfLetters��5   A   $��0q�6   
������$��60��6W   $��60��6b   $��5,70,5,0q�6n   $	��Top=�6�   #���   6�   .��5      �� $��	inbox.png��6    J� RenderTransformOrigin$ 0.607,0.509&�6+   $��54��6O   5      �� 5      -   5        $��	bSettings��5   Z   
������$��0q�6.   
������$��60��6k   $��60��6v   $��5,0,5,5q�6�   $��Bottom=�6�   #���   6�   .��5      �� $��settings.png��6   5      5       � 5   
   -   5          �Name$ f��5      $��2��6     FrameStyle1#���  6+     � Source$ 
Inbox.xaml?�6Q   5      5      