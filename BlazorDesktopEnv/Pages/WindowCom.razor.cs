namespace BlazorDesktopEnv.Pages;

public partial class WindowCom
{
        private string WindowStyle => $"""
                                   
                                       outline: 1px solid black;
                                       width: {width}px;
                                       height: {height}px;
                                       position: fixed;
                                       left: {originX}px;
                                       top: {originY}px;

                                   """;

    private string GrabLeftStyle => $"""
                                     
                                         background-color: {(resizingLeft ? "red" : "transparent")};
                                         outline: 1px dotted red;
                                         width: {grabSize}px;
                                         height: {height}px;
                                         position: fixed;
                                         left: {originX}px;
                                         top: {originY}px;

                                     """;

    private string GrabRightStyle => $"""
                                      
                                          background-color: {(resizingRight ? "red" : "transparent")};
                                          outline: 1px dotted red;
                                          width: {grabSize}px;
                                          height: {height}px;
                                          position: fixed;
                                          left: {originX + width - grabSize}px;
                                          top: {originY}px;

                                      """;

    private string GrabTopStyle => $"""
                                    
                                        background-color: {(resizingTop ? "red" : "transparent")};
                                        outline: 1px dotted red;
                                        width: {width}px;
                                        height: {grabSize}px;
                                        position: fixed;
                                        left: {originX}px;
                                        top: {originY}px;

                                    """;

    private string GrabBottomStyle => $"""
                                       
                                           background-color: {(resizingBottom ? "red" : "transparent")};
                                           outline: 1px dotted red;
                                           width: {width}px;
                                           height: {grabSize}px;
                                           position: fixed;
                                           left: {originX}px;
                                           top: {originY + height - grabSize}px;

                                       """;
}