import { Component, OnInit, NgModule } from '@angular/core';
import { Router } from '@angular/router';
import { RandomNumberDto } from '../shared/models/randomNumberDto';
import { RandomNumberService } from '../_services/randomNumberServices';
@Component({
  selector: 'app-randomNumber',
  templateUrl: './randomNumber.component.html',
  styleUrls: ['./randomNumber.component.css'],
})
export class RandomNumberComponent implements OnInit {
  fileSize: any;
  n: number = 1;
  floatCounter: number = 0;
  numCounter: number = 0;
  alphaCounter: number = 0;
  randomNumberDto: RandomNumberDto = new RandomNumberDto();
  constructor(private router: Router,private randomNumberService: RandomNumberService,) { }

  ngOnInit() {
  }
  async start() {
    debugger;
    this.n=1;
    while (this.n == 1) {
      await this.randomNumberService.generateRandomNumber(this.fileSize).then(resp => {
        this.randomNumberDto = resp as RandomNumberDto;
        this.alphaCounter = this.randomNumberDto.alphaCounter + this.alphaCounter;
        this.floatCounter = this.randomNumberDto.floatCounter + this.floatCounter;
        this.numCounter = this.randomNumberDto.numCounter + this.numCounter;
        
      }, error => {
        console.log(error);
      });
      if (this.fileSize != null && this.fileSize != 0 && this.fileSize != undefined) {
        if (parseFloat(this.fileSize)*1024 <= this.randomNumberDto.fileSize) {
          alert("File Size is exceeded");
          break;
        }
      }
    }
  }
  stop() {
    this.n=2;
  }
  //-------------report--------------//

  viewReport(){
    debugger;
      // this.router.navigate(
      //   ['rptInvestmentDetail'],
      //   { queryParams: { id: selectedRecord.id } }
      // );
      //this.router.navigate(['./rptInvestmentDetail'], {relativeTo: this.router});
      //this.router.navigate( ['/','rptInvestmentDetail', selectedRecord.id]);
      this.router.navigate([]).then(result => {  window.open('/reportDetail', '_blank'); });;
      
  
    }
}

