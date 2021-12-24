import { Component, OnInit, NgModule } from '@angular/core';
import { Router } from '@angular/router';
import { IReportDetailDto, ReportDetailDto } from '../shared/models/reportDetailDto';
import { ReportDetailService } from '../_services/reportDetailServices';
@Component({
  selector: 'app-reportDetail',
  templateUrl: './reportDetail.component.html',
  styleUrls: ['./reportDetail.component.css'],
})
export class ReportDetailComponent implements OnInit {
  alphaNumericPerct: number=0;
  floatPerct: number=0;
  numericPerct: number=0;
  fileSize: any;
  process:any;
  n: number = 1;
  floatCounter: number = 0;
  numCounter: number = 0;
  alphaCounter: number = 0;
  reportDetailDto: IReportDetailDto[]=[];
  constructor(private router: Router,private reportDetailService: ReportDetailService,) { }

  ngOnInit() {
    this.viewReport();
  }
  // async start() {
  //   debugger;
  //   this.n=1;
  //   while (this.n == 1) {
  //     this.process=await this.reportDetailService.generateReportDetail(this.fileSize).then(resp => {
  //       this.reportDetailDto = resp as ReportDetailDto;
  //       this.alphaCounter = this.reportDetailDto.alphaCounter + this.alphaCounter;
  //       this.floatCounter = this.reportDetailDto.floatCounter + this.floatCounter;
  //       this.numCounter = this.reportDetailDto.numCounter + this.numCounter;
        
  //     }, error => {
  //       console.log(error);
  //     });
  //     if (this.fileSize != null && this.fileSize != 0 && this.fileSize != undefined) {
  //       if (parseFloat(this.fileSize)*1024 <= this.reportDetailDto.fileSize) {
  //         alert("File Size is exceeded");
  //         break;
  //       }
  //     }
  //   }
  // }
  
  //-------------report--------------//

  viewReport(){
    debugger;
    this.reportDetailService.viewRandomNumberReport().subscribe(resp => {
      debugger;
      this.reportDetailDto = resp as IReportDetailDto[];
      this.alphaNumericPerct=this.reportDetailDto[0].alphaNumericPerct;
      this.floatPerct=this.reportDetailDto[0].floatPerct;
      this.numericPerct=this.reportDetailDto[0].numericPerct;
      
    }, error => {
      console.log(error);
    });
  
    }
}

