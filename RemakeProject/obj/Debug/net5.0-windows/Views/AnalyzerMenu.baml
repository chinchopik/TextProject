   M S B A M L   `   `   `  ????H  DRemakeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RemakeProjectRemakeProject  5   	   C&clr-namespace:RemakeProject.ViewModelsRemakeProject.ViewModels  5   	        RemakeProject.AnalyzerMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RemakeProject     5   	   5vm&clr-namespace:RemakeProject.ViewModels     5   	     ? Title$  TextAnalyzer??5	   	   $	??350??6   $	??600??6+    ? WindowStartupLocation$ CenterScreen=?67    ? DataContext 5      *  $RemakeProject.ViewModels.TextAnalyze  5   
   .??5      ?  ? ShowGridLines$ False??6    ? ColumnDefinitions 5   
   ?? 5      $
??0.1* ?6   ?? 5      ?? 5      $
??0.5* ?6   ?? 5      $
??0.1* ?6    ? RowDefinitions 5   
   ?? 5      $
??0.1* ?6   ?? 5      ?? 5      $??0.35* ?6   ??5   
   ?? 5       ?? Color$ #D3CCE3??6   .+?5    
   ?? $??2??6   $??Center=?5!      ?? 5"       ?? TextDecorations$
 None{?6   .?6/   .?5#      ?? ??6   ?? *CurrentUser+ ?? Mode$ OneWay=?5$      5%      ?? 5&   
   -   5        	 ??Name$	 textBox??5&         InputBoxStyle#???   5'      ??5(      ?? *Text+
 ?? UpdateSourceTrigger$
 PropertyChanged=??? 5*   
   $??Гласные:??6   $??0,10,0,0q?5+        
LabelStyle#???  5,      ?? 5-   
   -   5         ??Name$ Vowels??5-      $??	35,15,0,0q?5.        CountSymbolsStyle#???  5/      ??50      ?? *Vowels+$ OneWay=??? 52   
   $??Согласные:??6   $??0,40,0,0q?53      #???  54      ?? 55   
   -   5        $ 
Consonants??55      $??	35,45,0,0q?56      #???  58      ??57      ?? *
Consonants+$ OneWay=?58      ?? 5:   
   $??Цифры:??6   $??0,70,0,0q?5;      #???  5<      ?? 5=   
   -   5        $ Numbers??5=      $??	35,75,0,0q?5>      #???  5A      ??5@      ?? *	Numbers+$ OneWay=?5A      ?? 5C   
   $??Символы:??6   $??	0,100,0,0q?5D      #???  5E      ?? 5F   
   -   5        $ SpecialSymbols??5F      $??
35,105,0,0q?5G      #???  5I      ??5H      ?? *SpecialSymbols+$ OneWay=?5I      ?? 5K   
   -   5         ??Name$ FileInputButton??5K        FileInputStyle#???  5M      ??5L      ??  ?? Path$ 	FileInput?5M      5N      5O      