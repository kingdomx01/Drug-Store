   M S B A M L   `   `   `  ����D  @DrugStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:DrugStore.Menu_ElementsDrugStore.Menu_Elements  5      8    2DrugStore.Menu_Elements.SalesManagementUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:DrugStore.Menu_Elements     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   o� 
�������$��15(�6"   $��0��60   .@�5      m� -   5         � ToolTip$ Create new sales order��5      ��5      �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� $��	Underline{�6$   $��N��6@   $��0q�6I    �� Padding$ 0q�6T   �� 5      $��ew Order��6$   $��0q�64   $ 0q�6?   5      5      m� 5      -   5        $ Manage Order��5      ��5      �� 5      $ 
Horizontal=�6!   .+�5      �� $��	Underline{�6$   $��M��6@   $��0q�6I   $ 0q�6T   �� 5      $��anage Order��6$   $��0q�67   $ 0q�6B   5      5      m� 5       -   5        $ Manage Customer��5       ��5!      �� 5"      $ 
Horizontal=�6!   .+�5#      �� $��	Underline{�6$   $��M��6@   $��0q�6I   $ 0q�6T   �� 5$      $��anage Customer��6$   $��0q�6:   $ 0q�6E   5%      5'       � 	Resources 5)       �� 
TargetType �� Property �� Value �� Triggers	 P� Property
 P� Value��%Y  'm�       �� 5*      " m�6   .�5+      ��  � ��
 �   �63   �� 5,       � ��
 �����63   �� 5-       � ��$
 10,5q�60   �� 5.       � ��$ 0,0,0,1q�6/    5/      P� 50      	 �@m�IsHighlighted
 . . �51      ��  � ��
 �����6;   �� 52       � ��
 �   �6;   53      55      56      57      � 58   
   -   5         �Name$ Content��58      $��1��6     59      �� 5:      $	��26* �6    �� 5;      $
��113* �6    .+�5=       � -   5          �Name$ MainSalesManagementFrame��5=        � NavigationUIVisibility$ Hidden=�66   $��2��6V   5>      5?      5@      