export interface IReportDetailDto {
    alphaNumeric: string;
    float: number;
    numeric: number;
    alphaNumericPerct: number;
    floatPerct: number;
    numericPerct: number;
    
  }
  export class ReportDetailDto implements IReportDetailDto {
    alphaNumeric: string="";
    float: number=0;
    numeric: number=0;
    alphaNumericPerct: number=0;
    floatPerct: number=0;
    numericPerct: number=0;
    
  }