   M S B A M L   `   `   `  ����H  DProjetoCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjetoCSharpProjetoCSharp  5   	       ProjetoCSharp.TelaUsuario   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:ProjetoCSharp     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � Title$  Controle do Usuário��5	   	   $	��720��6%   $
��1024��62   $	��720��6?   $
��1024��6O    � WindowStartupLocation$ CenterScreen=�6_    � WindowStyle$ ThreeDBorderWindow=�6�    � SizeToContent$ WidthAndHeight=�6�    � 
ResizeMode$ CanMinimize=�5
   	   $��Center=�69   $��Center=�6V   $��Center=�6q   $��Center=�6�   .��5      � ��5   
   �� 5         bkgColor �� Color# �   6   .+�5   
   �� $��
23,3,0,544q�6   $
��Left=�6$   $	��130��6?   ��5      �� 5       �� 	UriSource$ /img/open-book.png?�6   5      � 5   
   -   5         �Name$ gridConteudo��5      $
��Left=�6%   $	��691��6@   $��	175,0,0,0q�6M   $	��Top=�6`   $	��843��6x   � 5   
   $	��175��6   $
��Left=�6   .+�5      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TransitioningContentSlide��5   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+
   Duration$
 0:0:0.2X�.��5      � -   5        $ 
GridCursor��5      $��	0,151,0,0q�6+   ���	#FFFF9800$��5��6U   $
��Left=�6_   $��39��6z   $	��Top=�6�   5      �� 5      -   5         ��Name$ ListViewMenu��5      $
��Left=�6-   $	��540��6H   $��	5,151,0,0q�6U   $	��Top=�6h   $	��170��6�   ���	#89000000$��0q�6�     ListViewStyle1#���  6�    �� SelectedIndex$ 0��6(  ��6�   Z� ��5      �� 5      $ 	#FF252121��6&   .@�5!      �� $��40��6   $��15(�6+     ListViewItemStyle1#���  69   $��0,0,0,1q�6f   
������ 
������ $��Center=�6�   .��5"      �� $
��20 0q�6    $��Cadastrar Livro��6.   
�������6E   5#      �� 5$      $��40��6   $��15(�6,   #���  6:   $��0,0,0,1q�6g   
������ 
������ .��5%      �� $
��20 0q�6    $��Cadastrar Gênero��6.   
�������$	��122��6]   5&      �� 5'      $��40��6   $��15(�6,   #���  6:   $��0,0,0,1q�6g   
������ 
������ .��5(      �� $
��20 0q�6    $��Listar Livros��6.   
�������6C   5)      �� 5*      $��40��6   $��15(�6,   #���  6:   $��0,0,0,1q�6g   
������ 
������ .��5+      �� $
��20 0q�6    $��Vender��6.   
�������$	��122��6S   5,      �� 5-      $��40��6   $��15(�6,   #���  6:   $��0,0,0,1q�6g   
������ 
������ .��5.      �� $
��20 0q�6    $��Listar Vendas��6.   
�������$	��122��6Z   5/      50      51      53      55      