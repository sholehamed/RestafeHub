(function($) {
    /* "use strict" */


	var dzChartlist = function(){
	
		var screenWidth = $(window).width();
			
		var widgetChart1 = function(){
			if(jQuery('#widgetChart1').length > 0 ){
				const chart_widget_1 = document.getElementById("widgetChart1").getContext('2d');
	
				new Chart(chart_widget_1, {
					type: "line",
					data: {
						labels: ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی"],
						datasets: [{
							label: "آمار فروش",
							backgroundColor: ['rgba(234, 73, 137, .13)'],
							borderColor: '#ea4989',
							pointBackgroundColor: '#ea4989',
							pointBorderColor: '#ea4989',
							borderWidth:2,
							pointHoverBackgroundColor: '#ea4989',
							pointHoverBorderColor: '#ea4989',
							data: [8, 7, 6, 3, 2, 4, 6, 8, 12, 6, 12, 13, 10, 18, 14, 24, 16, 12, 19, 21, 16, 14, 24, 21, 13, 15, 27, 29, 21, 11, 14, 19, 21, 17]
						}]
					},
					options: {
						title: {
							display: !1
						},
						tooltips: {
							intersect: !1,
							mode: "nearest",
							xPadding: 10,
							yPadding: 10,
							caretPadding: 10,
							bodyFontFamily: 'yekan',
							titleFontFamily: 'yekan',
							titleFontFamily: 'yekan'
						},
						legend: {
							display: !1
						},
						responsive: !0,
						maintainAspectRatio: !1,
						hover: {
							mode: "index"
						},
						scales: {
							xAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Month"
								}
							}],
							yAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Value"
								},
								ticks: {
									beginAtZero: !0
								}
							}]
						},
						elements: {
							
							point: {
								radius: 0,
								borderWidth: 0
							}
						},
						layout: {
							padding: {
								left: 0,
								right: 0,
								top: 5,
								bottom: 0
							}
						}
					}
				});
	
			}
		}
		
		var widgetChart2 = function(){
			if(jQuery('#widgetChart2').length > 0 ){
				const chart_widget_2 = document.getElementById("widgetChart2").getContext('2d');
	
				new Chart(chart_widget_2, {
					type: "line",
					data: {
						labels: ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی"],
						datasets: [{
							label: "آمار فروش",
							backgroundColor: ['rgba(234, 73, 137, .13)'],
							borderColor: '#ea4989',
							pointBackgroundColor: '#ea4989',
							pointBorderColor: '#ea4989',
							borderWidth:2,
							pointHoverBackgroundColor: '#ea4989',
							pointHoverBorderColor: '#ea4989',
							data: [19, 21, 16, 14, 24, 21, 13, 15, 27, 29, 21, 11, 14, 19, 21, 17, 12, 6, 12, 13, 10, 18, 14, 24, 16, 12, 8, 7, 6, 3, 2, 7, 6, 8]
						}]
					},
					options: {
						title: {
							display: !1
						},
						tooltips: {
							intersect: !1,
							mode: "nearest",
							xPadding: 10,
							yPadding: 10,
							caretPadding: 10,
							bodyFontFamily: 'yekan',
							titleFontFamily: 'yekan',
							titleFontFamily: 'yekan'
						},
						legend: {
							display: !1
						},
						responsive: !0,
						maintainAspectRatio: !1,
						hover: {
							mode: "index"
						},
						scales: {
							xAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Month"
								}
							}],
							yAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Value"
								},
								ticks: {
									beginAtZero: !0
								}
							}]
						},
						elements: {
							
							point: {
								radius: 0,
								borderWidth: 0
							}
						},
						layout: {
							padding: {
								left: 0,
								right: 0,
								top: 5,
								bottom: 0
							}
						}
					}
				});
	
			}
		}
		var widgetChart3 = function(){
			if(jQuery('#widgetChart3').length > 0 ){
				const chart_widget_3 = document.getElementById("widgetChart3").getContext('2d');
	
				new Chart(chart_widget_3, {
					type: "line",
					data: {
						labels: ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی"],
						datasets: [{
							label: "آمار فروش",
							backgroundColor: ['rgba(234, 73, 137, .13)'],
							borderColor: '#ea4989',
							pointBackgroundColor: '#ea4989',
							pointBorderColor: '#ea4989',
							borderWidth:2,
							pointHoverBackgroundColor: '#ea4989',
							pointHoverBorderColor: '#ea4989',
							data: [8, 7, 6, 3, 2, 4, 6, 8, 10, 6, 12, 15, 13, 15, 14, 13, 21, 11, 14, 10, 21, 10, 13, 10, 12, 14, 16, 14, 12, 10, 9, 8, 4, 1]
						}]
					},
					options: {
						title: {
							display: !1
						},
						tooltips: {
							intersect: !1,
							mode: "nearest",
							xPadding: 10,
							yPadding: 10,
							caretPadding: 10,
							bodyFontFamily: 'yekan',
							titleFontFamily: 'yekan',
							titleFontFamily: 'yekan'
						},
						legend: {
							display: !1
						},
						responsive: !0,
						maintainAspectRatio: !1,
						hover: {
							mode: "index"
						},
						scales: {
							xAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Month"
								}
							}],
							yAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Value"
								},
								ticks: {
									beginAtZero: !0
								}
							}]
						},
						elements: {
							
							point: {
								radius: 0,
								borderWidth: 0
							}
						},
						layout: {
							padding: {
								left: 0,
								right: 0,
								top: 5,
								bottom: 0
							}
						}
					}
				});
	
			}
		}
		var widgetChart4 = function(){
			if(jQuery('#widgetChart4').length > 0 ){
				const chart_widget_4 = document.getElementById("widgetChart4").getContext('2d');
	
				new Chart(chart_widget_4, {
					type: "line",
					data: {
						labels: ["فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی", "بهمن", "اسفند", "فروردین", "اردیبهشت", "خرداد", "تیر", "مرداد", "شهریور", "مهر", "آبان", "آذر", "دی"],
						datasets: [{
							label: "آمار فروش",
							backgroundColor: ['rgba(234, 73, 137, .13)'],
							borderColor: '#ea4989',
							pointBackgroundColor: '#ea4989',
							pointBorderColor: '#ea4989',
							borderWidth:2,
							pointHoverBackgroundColor: '#ea4989',
							pointHoverBorderColor: '#ea4989',
							data: [20, 18, 16, 12, 8, 10, 13, 15, 12, 6, 12, 13, 10, 18, 14, 16, 17, 15, 19, 16, 16, 14, 18, 21, 13, 15, 18, 17, 21, 11, 14, 19, 21, 17]
						}]
					},
					options: {
						title: {
							display: !1
						},
						tooltips: {
							intersect: !1,
							mode: "nearest",
							xPadding: 10,
							yPadding: 10,
							caretPadding: 10,
							bodyFontFamily: 'yekan',
							titleFontFamily: 'yekan',
							titleFontFamily: 'yekan'
						},
						legend: {
							display: !1
						},
						responsive: !0,
						maintainAspectRatio: !1,
						hover: {
							mode: "index"
						},
						scales: {
							xAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Month"
								}
							}],
							yAxes: [{
								display: !1,
								gridLines: !1,
								scaleLabel: {
									display: !0,
									labelString: "Value"
								},
								ticks: {
									beginAtZero: !0
								}
							}]
						},
						elements: {
							
							point: {
								radius: 0,
								borderWidth: 0
							}
						},
						layout: {
							padding: {
								left: 0,
								right: 0,
								top: 5,
								bottom: 0
							}
						}
					}
				});
	
			}
		}
		var chartBar = function(){
			var options = {
				  series: [
					{
						name: 'سود خالص',
						data: [31, 40, 28, 51, 42, 109, 100],
						
					
						//radius: 12,	
					}, 
					{
					  name: 'درآمد',
					  data: [11, 32, 45, 32, 34, 52, 41],
					  
					}, 
					
				],
					chart: {
					type: 'area',
					height: 350,
					fontFamily: 'yekan',
					toolbar: {
						show: false,
					},
					
				},
				plotOptions: {
				  bar: {
					horizontal: false,
					columnWidth: '55%',
					endingShape: 'rounded'
				  },
				},
				colors:['#e5aff8', '#e3366b'],
				dataLabels: {
				  enabled: false,
				},
				markers: {
			shape: "circle",
			
			},
			
			
				legend: {
					show: true,
					fontSize: '12px',
					fontFamily:'yekan',
					
					labels: {
						colors: '#000000',
						fontFamily:'yekan',
						
					},
					position: 'bottom',
					horizontalAlign: 'center', 	
					markers: {
						width: 19,
						height: 19,
						strokeWidth: 0,
						strokeColor: '#fff',
						fillColors: undefined,
						radius: 4,
						offsetX: 0,
						offsetY: 0,
						fontFamily:'yekan',
					}
				},
				stroke: {
				  show: true,
				  width: 0,
				  colors:['#e5aff8', '#e3366b'],
				},
				
				grid: {
					borderColor: '#eee',
				},
				xaxis: {
					
				  categories: ['فروردین', 'اردیبهشت', 'خرداد', 'تیر', 'مرداد', 'شهریور', 'مهر'],
				  labels: {
					style: {
						colors: '#3e4954',
						fontSize: '13px',
						fontFamily: 'yekan',
						fontWeight: 100,
						cssClass: 'apexcharts-xaxis-label',
					},
				  },
				  crosshairs: {
				  show: false,
				  }
				},
				yaxis: {
					labels: {
				   style: {
					  colors: '#3e4954',
					  fontSize: '13px',
					  fontFamily: 'yekan',
					  fontWeight: 100,
					  cssClass: 'apexcharts-xaxis-label',
				  },
				  },
				},
				fill: {
					type: 'solid',
					opacity: 0.8,
				},
				tooltip: {
					bodyFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					titleFontFamily: 'yekan',
				  y: {
					
					formatter: function (val) {
					  return  val + " میلیون تومان "
					}
				  }
				}
				};
	
				var chartBar1 = new ApexCharts(document.querySelector("#chartBar"), options);
				chartBar1.render();
		}
		var chartTimeline = function(){
			
			var optionsTimeline = {
				chart: {
					type: "bar",
					height: 400,
					stacked: true,
					fontFamily: 'yekan',
					
					toolbar: {
						show: false
					},
					sparkline: {
						//enabled: true
					},
					backgroundBarRadius: 5,
					offsetX: -10,
				},
				series: [
					 {
						name: "مشتریان جدید",
						data: [20, 40, 60, 35, 50, 70, 30, 15, 35, 40, 50, 60, 75, 40, 25, 70, 20, 40, 65, 50]
					},
					{
						name: "مشتریان وفادار",
						data: [-28, -32, -12, -5, -35, -10, -30, -29, -18, -25, -38, -12, -22, -39, -35, -30, -10, -20, -35, -38]
					} 
				],
				
				plotOptions: {
					bar: {
						columnWidth: "45%",
						endingShape: "rounded",
						colors: {
							backgroundBarColors: ['rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)'],
							backgroundBarOpacity: 1,
							backgroundBarRadius: 5,
							opacity:0
						},
	
					},
					distributed: true
				},
				colors:['#dd2f6e', '#3e4954'],
				
				grid: {
					show: true,
				},
				legend: {
					show: false
				},
				fill: {
					opacity: 1
				},
				dataLabels: {
					enabled: false,
					colors:['#dd2f6e', '#3e4954'],
					dropShadow: {
						enabled: true,
						top: 1,
						left: 1,
						blur: 1,
						opacity: 1
					}
				},
				xaxis: {
					categories: ['01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20'],
					labels: {
						style: {
							colors: '#787878',
							fontSize: '13px',
							fontFamily: 'yekan',
							fontWeight: 400
							
						},
					},
					crosshairs: {
						show: false,
					},
					axisBorder: {
						show: false,
					},
				},
				
				yaxis: {
					//show: false
					labels: {
						style: {
							colors: '#787878',
							fontSize: '13px',
							fontFamily: 'yekan',
							fontWeight: 400
							
						},
					},
				},
				
				tooltip: {
					bodyFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					x: {
						show: true
					}
				}
		};
			var chartTimelineRender =  new ApexCharts(document.querySelector("#chartTimeline"), optionsTimeline);
			 chartTimelineRender.render();
		}

	var chartTimeline2 = function(){
		
		var optionsTimeline = {
			chart: {
				type: "bar",
				height: 400,
				stacked: true,
				toolbar: {
					show: false
				},
				sparkline: {
					//enabled: true
				},
				backgroundBarRadius: 5,
				offsetX: -10,
			},
			series: [
				 {
					name: "مشتریان جدید",
					data: [40, 40, 60, 35, 40, 55, 30, 15, 35, 37, 50, 60, 60, 40, 25, 60, 30, 40, 65, 50]
				},
				{
					name: "مشتریان وفادار",
					data: [-35, -32, -12, -30, -35, -25, -30, -29, -25, -25, -38, -33, -22, -39, -35, -30, -20, -20, -35, -38]
				} 
			],
			
			plotOptions: {
				bar: {
					columnWidth: "45%",
					endingShape: "rounded",
					colors: {
						backgroundBarColors: ['rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)'],
						backgroundBarOpacity: 1,
						backgroundBarRadius: 5,
						opacity:0
					},

				},
				distributed: true
			},
			colors:['#dd2f6e', '#3e4954'],
			
			grid: {
				show: true,
			},
			legend: {
				show: false
			},
			fill: {
				opacity: 1
			},
			dataLabels: {
				enabled: false,
				colors:['#dd2f6e', '#3e4954'],
				dropShadow: {
					enabled: true,
					top: 1,
					left: 1,
					blur: 1,
					opacity: 1
				}
			},
			xaxis: {
				categories: ['01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20'],
				labels: {
					style: {
						colors: '#787878',
						fontSize: '13px',
						fontFamily: 'yekan',
						fontWeight: 400
						
					},
				},
				crosshairs: {
					show: false,
				},
				axisBorder: {
					show: false,
				},
			},
			
			yaxis: {
				//show: false
				labels: {
					style: {
						colors: '#787878',
						fontSize: '13px',
						fontFamily: 'yekan',
						fontWeight: 400
						
					},
				},
			},
			
			tooltip: {
				x: {
					bodyFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					show: true
				}
			}
    };
		var chartTimelineRender =  new ApexCharts(document.querySelector("#chartTimeline2"), optionsTimeline);
		 chartTimelineRender.render();
	}

	var chartTimeline3 = function(){
		
		var optionsTimeline = {
			chart: {
				type: "bar",
				height: 400,
				stacked: true,
				toolbar: {
					show: false
				},
				sparkline: {
					//enabled: true
				},
				backgroundBarRadius: 5,
				offsetX: -10,
			},
			series: [
				 {
					name: "مشتریان جدید",
					data: [10, 40, 50, 35, 35, 60, 30, 15, 35, 50, 50, 55, 75, 40, 35, 60, 35, 40, 50, 50]
				},
				{
					name: "مشتریان وفادار",
					data: [-28, -22, -42, -5, -40, -30, -30, -29, -35, -25, -45, -20, -35, -39, -40, -30, -10, -20, -35, -38]
				} 
			],
			
			plotOptions: {
				bar: {
					columnWidth: "45%",
					endingShape: "rounded",
					colors: {
						backgroundBarColors: ['rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)', 'rgba(0,0,0,0)'],
						backgroundBarOpacity: 1,
						backgroundBarRadius: 5,
						opacity:0
					},

				},
				distributed: true
			},
			colors:['#dd2f6e', '#3e4954'],
			
			grid: {
				show: true,
			},
			legend: {
				show: false
			},
			fill: {
				opacity: 1
			},
			dataLabels: {
				enabled: false,
				colors:['#dd2f6e', '#3e4954'],
				dropShadow: {
					enabled: true,
					top: 1,
					left: 1,
					blur: 1,
					opacity: 1
				}
			},
			xaxis: {
				categories: ['01', '02', '03', '04', '05', '06', '07', '08', '09', '10', '11', '12', '13', '14', '15', '16', '17', '18', '19', '20'],
				labels: {
					style: {
						colors: '#787878',
						fontSize: '13px',
						fontFamily: 'yekan',
						fontWeight: 400
						
					},
				},
				crosshairs: {
					show: false,
				},
				axisBorder: {
					show: false,
				},
			},
			
			yaxis: {
				//show: false
				labels: {
					style: {
						colors: '#787878',
						fontSize: '13px',
						fontFamily: 'yekan',
						fontWeight: 400
						
					},
				},
			},
			
			tooltip: {
				x: {
					bodyFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					titleFontFamily: 'yekan',
					show: true
				}
			}
    };
		var chartTimelineRender =  new ApexCharts(document.querySelector("#chartTimeline3"), optionsTimeline);
		 chartTimelineRender.render();
	}
	
	/* Function ============ */
		return {
			init:function(){
				
			},
			
			
			load:function(){
				widgetChart1();	
				widgetChart2();	
				widgetChart3();	
				widgetChart4();	
				chartBar();	
				chartTimeline();
				chartTimeline2();
				chartTimeline3();
				
			},
			
			resize:function(){
			}
		}
	
	}();

	jQuery(document).ready(function(){
	});
		
	jQuery(window).on('load',function(){
		setTimeout(function(){
			dzChartlist.load();
		}, 1000); 
		
	});

	jQuery(window).on('resize',function(){
		
		
	});     

})(jQuery);