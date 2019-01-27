import { Component, OnInit } from '@angular/core';
import { MovingService } from './services/moving.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
 
  title = 'CarUI';

  constructor(private _movingService: MovingService) {
    
  }
  ngOnInit(): void {

  }

  
}


