   M S B A M L   `   `   `  ����D  @Expenselt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Expenselt	Expenselt  5   	       Expenselt.ExpenseReport   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Expenselt     5   	     � Title$  ExpenseIt - View Expense��5   	   $	��450��6*   $	��800��67   .��5	      � $��10, 0, 10, 10q�6   ��5
   
   �� 5       �� ImageSource$ /IC816740.jpeg��6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   � $��1��6    � RowDefinitions 5      �� 5      $��* �6    $	��150��6+   �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      � $��0��6   .+�5      �� $��20(�6   
���� ��$
��Bold"�6:   .��6L   Expense Report For:6a   5      � 5      $��1��6    5      �� 5      $��* �6'   �� 5      $��* �6'   .+�5       � $��0��6   .+�5!      �� $��15(�6   $
��Bold"�6*   .��6<   Name:6C   5"      � 5#      $��1��6   .+�5$      �� ��6   ��  �� Path$
 Name�5%      5&      � 5'      $��2��6    5(      �� 5)      $��* �6'   �� 5*      $��* �6'   .+�5,      � $��0��6   .+�5-      �� $��15(�6   $
��Bold"�6*   .��6<   Department:6I   5.      � 5/      $��1��6   .+�50      �� ��6   �� $ 
Department�51      52      � 53      $��3��6   .+�54      &   System.Windows.Controls.DataGrid     AutoGenerateColumns$ False��6A      RowHeaderWidth$ 0Q�6]      
IsReadOnly$
 True��6p   ��6   �� $ Expenses�   Columns 55      0  *System.Windows.Controls.DataGridTextColumn  56      ,  &System.Windows.Controls.DataGridColumn	   Header$	 ExpenseType��6-   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6B   �� $ ExpenseType�  57      $	 Amount��6-   
 6=   �� $ ExpenseAmount�59      5:      5;      5<      5=      