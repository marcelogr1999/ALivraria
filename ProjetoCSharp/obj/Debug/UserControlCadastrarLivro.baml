   M S B A M L   `   `   `  ����H  DProjetoCSharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ProjetoCSharpProjetoCSharp  5      -    'ProjetoCSharp.UserControlCadastrarLivro   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      'localclr-namespace:ProjetoCSharp  5      -   5        $��Center=�5	   7   $��Center=�6T   .��5      � $	��800��6   $	��600��6   .+�5   
   �� -   5          ��Name$  boxNomeLivro��5      $
��Left=�6)   $��40��6D    �� TextWrapping$
 Wrap=�6P   $	��Top=�6d   $	��206��6|   $��24(�6�   $��256,156,0,0q�6�   ���	#FFFF98006�   �� 5   
   -   5        $��listGeneros��5      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ - - - - - - - - - - - - ��6G    �� SelectedValuePath$ GeneroID��5       �� DisplayMemberPath$ 
GeneroNome��5      $��256,227,338,326q�5      $��24(�6$   $
��Left=�62   $��47��6T   ��5   &   �� *
lGeneros+ �� SelectedValue 5      �� *
nomeGenero+ �� Mode$ TwoWay=���5      �� 5       
  Orange �� Color# �   6"   5      �� 5   
   -   5        $  boxCod��5      $
��Left=�6"   $��40��6=   $
 Wrap=�6I   $	��Top=�6]   $	��206��6u   $��24(�6�   $��256,297,0,0q�6�   .��6�   ��5      �� 5      # �   6"   .��5   "   5      �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��Nome do Livro:��6C   $	��Top=�6Y   $��
76,164,0,0q�6q   $��24(�6�   ��5      �� 5        txtColor# �  6"   5!      �� 5"   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��
64,298,0,0q�6[   $��24(�6o   ��5#      �� 5$      # �  6"   �� 5%   %   $�Código do Livro��6)   �� 6B   $�:��6F   6R   �� 5&   
   $
��Left=�6   $
��Wrap=�6/   $��CADASTRO DO LIVRO��6C   $	��Top=�6\   $��40(�6t   $
��Bold"�6�   $��	64,75,0,0q�6�   $��76��6�   $	��472��6�   ��5'      �� 5(      # �  6"   5*      �� 5-   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��156,231,0,0q�6[   $��24(�6p   $��Gênero:��6~   ��5.      �� 5/      # �  6"   50   &   �� 51   
   -   5        $  boxValor��51      $
��Left=�6$   $��40��6?   $
 Wrap=�6K   $	��Top=�6_   $	��206��6w   $��24(�6�   $��256,357,0,0q�6�   .��6�   ��52      �� 53      # �   6"   .��54   "   55      �� 56   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��180,365,0,0q�6[   $��24(�6p   $��Valor:��6~   ��57      �� 58      # �  6"   59   &   �� 5:   
   -   5        $  boxDescricao��5:      $
��Left=�6(   $��40��6C   $
 Wrap=�6O   $	��Top=�6c   $	��480��6{   $��24(�6�   $��256,432,0,0q�6�    �� 	MaxLength$ 38��6�   .��6�   ��5;      �� 5<      # �   6"   .��5=   "   5>      �� 5?   
   $
��Left=�6   $
��Wrap=�6/   $	��Top=�6C   $��131,432,0,0q�6[   $��24(�6p   $��Descrição:��6~   ��5@      �� 5A      # �  6"   5B   &   �� 5D   
   -   5        	 ��Name$	 btnCadastrar��5D      $��	Cadastrar��6'   
 �� 	IsDefault
 . $	��Top=�6L   $��32(�6d   $
��Left=�6�   $��Center=�6�   $��Center=�6�   ���	#FF898080  btnTerminal#���  6  $��614,524,0,0q�6=  ��6r   Z� ��6�   Z� 6R  5F      5G      