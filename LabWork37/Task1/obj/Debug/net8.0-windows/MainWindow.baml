   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��500��6   $	��800��6)   .��5	      �� .+�5
   
   �� $(��"Введите имя файла: ��6   �� 5   
   -   5         ��Name$ inputTextBox��5      6(   �� 5   
   -   5         ��Name$ fileCountTextBlock��5      �� 5   
   $
��True��6   $	��400��6/   $
��Auto=�5      $
��Auto=�6<   .��5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ resultDataGrid��5         AutoGenerateColumns$ False��6+      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя файла��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *Name+  5      $ Расширение��6%    69   �� *	Extension+  5      $ Путь к файлу��6%    6;   �� *
FullName+  5      $ Размер��6%    65   �� *Length+  5      $ Дата создания��6%    6<   �� *CreationTime+  5      $! Дата изменения��6%    6=   �� *LastAccessTime+5      5      5      5      