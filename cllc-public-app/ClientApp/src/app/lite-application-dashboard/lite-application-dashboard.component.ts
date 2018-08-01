import { Component, OnInit, Input, ViewChild } from '@angular/core';
import { Subscription } from 'rxjs';
import { MatPaginator, MatTableDataSource, MatSort } from '@angular/material';
import { AdoxioApplicationDataService } from '../services/adoxio-application-data.service';
import { LicenseApplicationSummary } from '../models/license-application-summary.model';
import { FileSystemItem } from '../models/file-system-item.model';
import {saveAs } from "file-saver";

@Component({
  selector: 'app-lite-application-dashboard',
  templateUrl: './lite-application-dashboard.component.html',
  styleUrls: ['./lite-application-dashboard.component.scss']
})
export class LiteApplicationDashboardComponent implements OnInit {

  busy: Subscription;
  @Input() applicationInProgress: boolean;
  dataLoaded: boolean = false;

  //displayedColumns = ['name', 'establishmentName', 'establishmentAddress', 'status', 'licenseType', 'licenseNumber'];
  displayedColumns = ['establishmentName', 'name', 'cancel'];
  dataSource = new MatTableDataSource<LicenseApplicationSummary>();
  @ViewChild(MatPaginator) paginator: MatPaginator;
  //@ViewChild(MatSort) sort: MatSort;

  constructor(private adoxioApplicationDataService: AdoxioApplicationDataService) { }

  ngOnInit() {
    this.displayApplications();
  }

  private displayApplications() {
    let licenseApplicationSummary: LicenseApplicationSummary[] = [];
    this.busy = this.adoxioApplicationDataService.getAllCurrentApplications().subscribe(res => {

      // for Applications in progress display the ones not paid
      // for Applications submitted display the ones paid
      if (this.applicationInProgress) {
        this.displayedColumns = ['lastUpdated', 'establishmentName', 'cancel'];
      }
      else {
        this.displayedColumns = ['name'];
      }

      let adoxioApplications = res.json();
      adoxioApplications.forEach((entry) => {
        let licAppSum = new LicenseApplicationSummary();
        licAppSum.id = entry.id;
        licAppSum.name = entry.name;
        licAppSum.establishmentName = entry.establishmentName;
        licAppSum.establishmentAddress = entry.establishmentAddress;
        licAppSum.licenseType = entry.licenseType;
        licAppSum.status = entry.applicationStatus;
        licAppSum.isPaid = entry.isPaid;
        licAppSum.paymentreceiveddate = entry.paymentreceiveddate;
        licAppSum.createdon = entry.createdon;
        licAppSum.modifiedon = entry.modifiedon;

        if (this.applicationInProgress) {
          if (!licAppSum.isPaid) {
            licenseApplicationSummary.push(licAppSum);
          }
        }
        else {
          if (licAppSum.isPaid) {
            this.busy = this.adoxioApplicationDataService.getFileListAttachedToApplication(entry.id, 'Licence Application Main')
              .subscribe(res => {
                var files: FileSystemItem[] = res.json();
                if (files && files.length) {
                  licAppSum.applicationFormFileUrl = files[0].serverrelativeurl;
                  licAppSum.fileName = files[0].name;
                }
              });
            licenseApplicationSummary.push(licAppSum);
          }
        }
      });

      this.dataSource.data = licenseApplicationSummary;
      this.dataLoaded = true;
      setTimeout(() => {
        this.dataSource.paginator = this.paginator;
      });
    });
  }

  downloadApplicationPDF(url: string, fileName: string) {
    this.adoxioApplicationDataService.downloadFile(url)
    .subscribe((res: Blob) => {
      saveAs(res, fileName);
    });
  }

  cancelApplication(id: string) {
    // start by showing a confirmation dialog.
    if (confirm("Are you sure you want to cancel this application?")) {
      // delete the application.

      this.busy = this.adoxioApplicationDataService.deleteApplication(id).subscribe(
        res => {
          this.displayApplications();
        });

    }
  }

}
