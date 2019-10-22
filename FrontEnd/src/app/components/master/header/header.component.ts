import { Component, OnInit } from '@angular/core';
import { md5Text } from 'src/app/common/md5';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

  constructor() { }

  ngOnInit() {
    var md5 = md5Text('hello world');
  }

}
