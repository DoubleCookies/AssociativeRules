# AssociativeRules

AssociativeRules project was created for datatable analysis of some children diseases. This code contains a lot of workarounds and non-effective solutions, but works in some way. Now it's just archive repository and reminder for myself how I **shouldn't** write code.

## Structure

  - AssocRulesWorker - main module
  - ConApriori_Version2 - modification of classical Apriori algorithm for creating associative rules (created by Vladimir Billig)
  - ExcelTest - module for transforming xls files into csv *(what a "good" name for module)*. 
  - ExpandingRules - module for saving results in human-readable text file.
  - Medicine2 - module for transforming csv files into binary format *(another "good" name)*.
   
## Algorithm

- Transform xls into csv file.
- Change all cells with data (excluding row names) with binary analogues of those parameters (for example height can be "small", "medium" and "big")
- Tranform file with binary parameters into special **scale** format (special enumarion with bit flags)
- Use Con-apriori algorithm for creating associative rules
- (Optional) Filter rules and transform them into in human-readable text-file.
