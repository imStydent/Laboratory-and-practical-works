   M S B A M L   `   `   `  ����@  <Task3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task3Task3  5   	       Task3.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task3     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      &   System.Windows.Controls.DataGrid  -   5          Name$ gamesDataGrid��5	         CanUserAddRows$ False��6&      CanUserDeleteRows$ False��6=      RowBackground
 ��ح�   AlternatingRowBackground
 �����   AutoGenerateColumns$ False��5
   E      Columns 5   
   0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ GameId��6!   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 61   �� 
 �� Path$
 GameId�  5      $
 Name��6!   	 6/   �� $

 Name�5  /System.Windows.Controls.DataGridHyperlinkColumn  5      $
 Site��6&   	 64   �� $

 Site�  5      $ Category��6!   	 63   �� $
 Category�  5      $ Price��6!   	 60   �� $
 Price� �� StringFormat$ {0:C}��4  .System.Windows.Controls.DataGridComboBoxColumn  5      $ Category��6%   5      4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      � .+�5      ��  ��Name$ 
infoButton��6%   -   5        $��Подробнее��5   9   6M   �� 5      $ 
editButton��6%   $ ��Редактировать��69   �� 5      $ deleteButton��6%   $��Удалить��6;   5      5      5      5       5!      