   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseltHome   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  Expenselt - Home��5   	   $	��500��6"   $	��800��6/   .��5	      � $��10, 0, 10, 10q�6   ��5
   
   �� 5       �� ImageSource$ /IC816740.jpeg��6    � ColumnDefinitions 5   
   �� 5      �� 5      $	��230 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   � $��0��6   $��0��6   .+�5      �� $��Last Previewed:��6   $��	10 10 0 0q�6.   $
��Bold"�6A   5      �� 5   
   -   5         ��Name$ lastCheckedListBox��5   /   $��0��6   $��2��6"   ��6K   ��  �� Path$ PersonsChecked�� 5   
   $��0��6   $��3��6   .+�5      �� $��Bottom=�6   $
��Left=�6/   $��	10 0 0 10q�6J   ��6]   �� $ LastChecked�5      �� 5   
   $��1��6   ��6    ��  �� RelativeSource ��  �� AncestorType" �$ MainCaptionText�6�   �� 5    
   $��35��6    �� Padding$ 5q�6   ���#4E87D4$��1��6>   $��1��6N   ._�5!      �� $��Center=�6   
�������.��6B   Names6I   5"      �� 5#   
   -   5        $ peopleListBox��5#      $��1��5$      $��2��5%      ��5'      ��  �� " �$ ExpenseDataSource���5(      �� 5)      .R�5*      �� ��6   �� $
 Name�5+      5-      �� 5/   
   -   5        $��0, 10, 0, 0q�5/      $��1��50      $��3��51      $	��125��52      $��25��53      $��Right=�54      ��56      �� 	 �� ElementName$	 peopleListBox��$ SelectedItem.Name�59      5:      