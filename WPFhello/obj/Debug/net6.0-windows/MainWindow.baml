   M S B A M L   `   `   `  ����C  ?WPFhello, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WPFhelloWPFhello  5   	       WPFhello.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6'   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     6i   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   (localclr-namespace:WPFhello     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5      � -   5         �Name$ MainGrid��5      .+�5   
   �� -   5        $��
helloLabel��5   F   $��Hello, WPF!��6   $��30(�6&   $
��Bold"�64   $��10,0,0,0q�6X   $
��Left=�6j   $	��Top=�6�   �� 5   
   $��30��6   $	��175��6   $��	10,55,0,0q�6+   $
��Left=�6>   $	��Top=�6Y   6s   �� 5	   
   $��Име:��6   $��	10,58,0,0q�6   $
��Left=�62   $	��Top=�6M   �� 5
   
   -   5         ��Name$ 	inputName��5
      $	��120��6%   $
��Left=�61   $��	62,62,0,0q�6L   $	��Top=�6_    �� TextWrapping$
 Wrap=�6w   �� 5   
   $��30��6   $	��175��6   $��	10,85,0,0q�6+   $
��Left=�6>   $	��Top=�6Y   �� 5   
   $��Име:��6   $��	10,88,0,0q�6   $
��Left=�62   $	��Top=�6M   �� 5   
   -   5        $ inputName_Copy��5      $	��120��6*   $��	62,92,0,0q�66   $
��Left=�6I   $	��Top=�6d   $
 Wrap=�6|   �� 5   
   $��30��6   $	��175��6   $��
10,115,0,0q�6+   $
��Left=�6?   $	��Top=�6Z   �� 5   
   $��Име:��6   $��
10,118,0,0q�6   $
��Left=�63   $	��Top=�6N   �� 5   
   -   5        $ inputName_Copy2��5      $	��120��6+   $��
62,122,0,0q�67   $
��Left=�6K   $	��Top=�6f   $
 Wrap=�6~   �� 5   
   -   5         ��Name$ btnHello��5      $��Здрасти��6#   $��134,154,0,0q�6L   $	��Top=�6a   $
��Left=�6y   �� 5   
   -   5         ��Name$ peopleListBox��5      $��	0,55,10,0q�6)   $	��150��6<   $	��110��6H   $��Right=�6U   $	��Top=�6q   .@�5      �� $
��Mike��6   �� 5      $
��Lisa��6   �� 5      $
��John��6   �� 5      $
��Mary��6   5      �� 5   
   -	   5        $ btnHelloToSelectedItem��5      $��Здрасти��61   $��50��6C   $��20��6N   $��0,174,110,0q�6Z   $��Right=�6o   $	��Top=�6�   6�   5      5      