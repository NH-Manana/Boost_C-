   M S B A M L   `   `   `  ����>  :GVP, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:GVP.Views	GVP.Views  5   	       GVP.Views.LoginWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:GVP.Views     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	     � Title$  Login��5	   	   $	��530��6   $	��900��6$    � WindowStyle$
 None=�5
   	    � AllowsTransparency$
 True��6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��179* �6   �� 5      .+�5   
   �� $��/Views/assets/place.png��6   $
��Left=�61   $	��530��6L   $��Center=�6Y   $	��480��6t   $
��Fill=�6�   �� 5   
   $��Company��6   $
��Left=�6"   $	��Top=�6=   $��Italic$�6U   $��Arial)�6h   $
��Bold"�6{   ���	#FFE2E1E1$��28(�6�   $��	10,10,0,0q�6�   �� 5   
   $��Se connecter��6   $
��Left=�6'   $��
509,58,0,0q�6B   $	��Top=�6V   $��22(�6n   $
��Bold"�6|   $��Century Gothic)�6�   �� 5   
   $��Bienvenue !��6   $
��Left=�6&   $��
509,21,0,0q�6A   $	��Top=�6U   $��18(�6m   $
��Bold"�6{   $��Century Gothic)�6�   �� 5   
   -   5         ��Name$ lbNomLog��5      $	��Nom��6"   $
��Left=�60   $��528,157,0,0q�6K   $	��Top=�6`   $��Century Gothic)�6x   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5         ��Name$ 	tbNomLogi��5      $
��Left=�6%   $��533,189,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $	��318��6�   $��0,0,0,2q�6�   ���	#FF002E2C$��30��6�   $��Century Gothic)�6�   $��14(�6�   �� 5   
   -   5        $ 	lbPassLog��5      $��Mot de passe��6#   $
��Left=�6:   $��530,246,0,0q�6U   $	��Top=�6j   $��Century Gothic)�6�   $
��Bold"�6�   $��14(�6�   �� 5   
   -   5         ��Name$ 	btnSignIn��5      $��	Vérifier��6$   $
��Left=�67   $��530,431,0,0q�6R   $	��Top=�6g   ���	#FF353787
�������$��32��6�   $	��324��6�   $��14(�6�   6�   �� 5   
   -   5        $ lbPassForget��5      $��Mot de passe oubliée?��6&   $
��Left=�6F   $��687,399,0,0q�6a   $	��Top=�6v   $��Century Gothic)�6�   $��14(�6�   ���	#FF161CFF6�   �� 5   
   -   5        $ lbPassLog_Copy��5      $'��!Vous n'avez pas encore de compte?��6(   $
��Left=�6T   $��528,468,0,0q�6o   $	��Top=�6�   $��Century Gothic)�6�   $��14(�6�   $	��261��6�   �� 5   
   -   5        $ lbPassForget_Copy��5      $��	Créer-un��6+   $
��Left=�6>   $��782,468,0,0q�6Y   $	��Top=�6n   $��Century Gothic)�6�   $��14(�6�   ���	#FF161CFF$
��Bold"�6�   	 J� RenderTransformOrigin$	 
0.15,1.085&�6�   G� 5   
   -   5        
 G�Name$
 passbox��5      $
��Left=�6R   $��533,278,0,0q�6m   $	��Top=�6�   $	��318��6�   $��32��6�   $��0,0,0,2q�6�   ���	#FF3537876�   �� 5   
   -	   5        $ 	tbPassLog��5      $
��Left=�6I   $��534,280,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��318��6�   $��0,0,0,2q�6�   ���	#FF002E2C$��30��6�   $��Century Gothic)�6�   $��14(�6  $y�	Collapsed=�6  �� 5   
   -
   5         ��Name$ 
cbShowPass��5      $��Afficher le mot de passe��6'   $
��Left=�6J   $��533,341,0,0q�6e   $	��Top=�6z   $��14(�6�   $��Century Gothic)�6�   6�   �� 5   
   -   5        $ btnClose_Log��5        FontAwesome.WPF.Awesome   Content$ Close=�6'   $��30(�6B   $��	857,1,0,0q�6P   $	��Top=�6c   $��37��6{   $��0,1,0,0q�6�   $��2��6�   ��6�   Z� ��6�   Z� 6�   5       5!      