   M S B A M L   `   `   `  ����V  RDataStructuresAndAlgorithms, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:DataStructuresAndAlgorithmsDataStructuresAndAlgorithms  5   	   ,    &DataStructuresAndAlgorithms.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:DataStructuresAndAlgorithms     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5	      � .+�5
   
   �� -   5         ��Name$ dataSizeLabel��5
      $��	Data Size��6'   $
��Left=�6;   $��	10,10,0,0q�6V   $	��Top=�6i   	� 5   
   -   5         	�Name$ smallSizeButton��5      $��Small (100)��6/    	� 	GroupName$ databuttons��6E   $
��Left=�6]   $��	10,36,0,0q�6x   $	��Top=�6�   	� 5   
   -   5        $ mediumSizeButton��5      $��Medium (1000)��60   $ databuttons��6H   $
��Left=�6`   $��	10,56,0,0q�6{   $	��Top=�6�   	� 5   
   -   5        $ largeSizeButton��5      $��Large (10000)��6/   $ databuttons��6G   $
��Left=�6_   $��	10,76,0,0q�6z   $	��Top=�6�   	� 5   
   -   5        $ extraLargeSizeButton��5      $��Extra Large (100000)��64   $ databuttons��6S   $
��Left=�6k   $��	10,96,0,0q�6�   $	��Top=�6�   	� 5   
   -   5        $ fromXMLButton��5      $��Load From XML��6-   $ databuttons��6E   $
��Left=�6]   $	��Top=�6x   $��
10,116,0,0q�6�   �� 5   
   -   5        $ situationLabel��5      $��	Situation��6(   $
��Left=�6<   $	��Top=�6W   $��
171,10,0,0q�6o   	� 5   
   -   5        $ idealButton��5      $��Ideal (Ordered)��6+   $ 	situation��6E   $
��Left=�6[   $��
171,41,0,0q�6v   $	��Top=�6�   	� 5   
   -	   5        $ worstCaseButton��5      $ ��Worst Case (Reverse Order)��6/   $ 	situation��6T   $
��Left=�6j   $	��Top=�6�   $��
171,61,0,0q�6�   	� 5   
   -
   5        $ randomButton��5      $��Random (average)��6,   $ 	situation��6G   $
��Left=�6]   $	��Top=�6x   $��
171,81,0,0q�6�   �� 5   
   -   5        $ algorithmLabel��5      $��
Algorithms��6(   $
��Left=�6=   $	��Top=�6X   $��
365,10,0,0q�6p   �� 5   
   -   5         ��Name$ bubbleSortBox��5      $��
BubbleSort��6*   $
��Left=�6?   $��
365,41,0,0q�6Z   $	��Top=�6n   �� 5   
   -   5        $ selectionSortBox��5      $��SelectionSort��6-   $
��Left=�6E   $��
365,61,0,0q�6`   $	��Top=�6t   �� 5   
   -   5        $ insertionSortBox��5      $��InsertionSort��6-   $
��Left=�6E   $��
365,79,0,0q�6`   $	��Top=�6t   �� 5   
   -   5         ��Name$ 	runButton��5      $	��Run��6$   $
��Left=�62   $	��Top=�6M   $��75��6e   $��433,292,0,0q�6p   6�   �� 5   
   -   5        $ versionLabel��5      $��Version 1 (assignment 2)��6&   $
��Left=�6I   $	��Top=�6d   $��
10,285,0,0q�6|   �� 5   
   -   5        $ sequentialSearchBox��5      $��SequentialSearch��60   $
��Left=�6K   $��
365,99,0,0q�6f   $	��Top=�6z   �� 5   
   -   5        $ binarySearchBox��5      $��BinarySearch��6,   $
��Left=�6C   $��365,119,0,0q�6^   $	��Top=�6s   �� 5   
   -   5         ��Name$ 	searchBox��5      $
��Left=�6%   $��23��6@    �� TextWrapping$
 Wrap=�6L   $��Value to search for��6`   $	��Top=�6{   $	��120��6�   $��388,264,0,0q�6�   �� 5   
   -   5        $ recursiveBinaryBox��5      $��RecursiveBinarySearch��6/   $
��Left=�6O   $��365,139,0,0q�6j   $	��Top=�6   �� 5    
   -   5        $ mergeSortBox��5       $��	MergeSort��6)   $
��Left=�6=   $��365,159,0,0q�6X   $	��Top=�6m   �� 5!   
   -   5        $ quickSortBox��5!      $��	QuickSort��6)   $
��Left=�6=   $��365,179,0,0q�6X   $	��Top=�6m   �� 5"   
   -   5        $ proofBox��5"      $X��RDisable "Proof" (reduces runtime if you trust that the lists are sorted(they are))��6%   $
��Left=�6�   $��
10,225,0,0q�6�   $	��Top=�6�   5%      5&      