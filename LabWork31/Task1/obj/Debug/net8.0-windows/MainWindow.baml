   M S B A M L   `   `   `  ����@  <Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task1Task1  5   	       Task1.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task1     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��
Логин��6   �� 5   
   -   5         ��Name$ loginTextBox��5      $��1��6(    �� 	MaxLength$ 10��65   �� 5   
   $��Пароль��6   $��2��6!   G� 5   
   -   5         G�Name$ passwordBox��5      $��3��6+    G� 	MaxLength$ 10��68   �� 5   
   $-��'Подтверждение пароля��6   $��5��6/   G� 5   
   -   5        $ confirmationPasswordBox��5      $��6��67   $ 10��6D   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ birthdayDatePicker��5         DisplayDateStart 
01/01/199061   $��7��6O   5      �� 5    
   -   5         ��Name$ ageLabel��5       $��Возраст ��6"   $��8��65   �� 5!   
   $&�� Информация о себе��6   $��9��6,   �� 5"   
   -   5        $ userTextBox��5"      $��10��6'   	 �� AcceptsReturn$
	 True��65   
 �� TextWrapping$

 Wrap=�6J   �� 5#   
   -   5         ��Name$ registrationButton��5#      $��Регистрация��6-   $��11��6C   5$      5%      5&      