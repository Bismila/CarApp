import { Component, OnInit } from '@angular/core';
import {Ng2PageScrollModule} from 'ng2-page-scroll';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
  onAnchorClick(){
    // let x = document.querySelector("#anchor");
    // if (x){
    //     x.scrollIntoView();
    // }
  }
}
