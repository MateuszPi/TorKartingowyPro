   M S B A M L   `   `   `  ����H  DTorKartingowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TorKartingowyTorKartingowy  5   	       TorKartingowy.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TorKartingowy     5   	     � Title$  
MainWindow��5   	   $	��546��6   $	��500��6)   $	��500��65   $	��546��6D   .��5	      � $��0,0,0,-4q�6    � RowDefinitions 5
   
   �� 5      $
��130* �6   �� 5      $
��130* �6   �� 5      $
��130* �6   �� 5      $
��129* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ buttonZarzadzanie��5      $��Zarządzanie
��6,   $��0q�6g   �� 5   
   -   5        $ buttonTerminarz��5      $��Terminarz
��6*   $��0q�6a   $��1��6l   �� 5   
   -   5        $ 
buttonKasa��5      $��KASA
��6%   $��1��6R   $��0q�6_   �� 5   
   -   5        $ 
buttonLigi��5      $
��LIGI��6%   $��0q�64   $��1��6T   $��1��6a    K� ZIndex$ -2��6q   �� 5   
   -   5        $ 
buttonBaza��5      $��BAZA KLIENTÓW��6%   $��2��6Q   �� 5   
   -   5        $ buttonArchiwum��5      $��REKORDY I ARCHIWUM
��6)   $��2��6h   $��1��6u   �� 5   
   -   5         ��Name$ 
textLayout��5      $
��Left=�6(   $��5,59,0,0q�6C   $
��Wrap=�6U   $	��Top=�6i   $��39��6�   $	��246��6�   $��24(�6�   $��3��6�   $��2��6�   �� 6�   $�Dzisiejszy layout:��6�   6�   �� 5   
   -   5        $ blockLayout��5      $
��Left=�6)   $��39��6D   $��0,59,0,0q�6P   $
��Wrap=�6b   $	��Top=�6v   $	��246��6�   $��24(�6�   $��3��6�   $��1��6�   �� 5   
   -	   5        $ textNaTorze��5      $
��Left=�6)   $��5,20,0,0q�6D   $
��Wrap=�6V   $��	Na torze:��6j   $	��Top=�6{   $��39��6�   $	��246��6�   $��24(�6�   $��3��6�   $��2��6�   �� 5   
   -
   5        $ blockNaTorze��5      $
��Left=�6*   $��39��6E   $
��Wrap=�6Q   $	��Top=�6e   $	��246��6}   $��24(�6�   $��3��6�   $��1��6�   $��0,20,0,0q�6�   �� 5   
   -   5        $��Button��5      $
��Left=�6"   $��21��6=   $��
10,103,0,0q�6I   $��3��6]   $	��Top=�6j   $��90��6�   6�   5       5!      